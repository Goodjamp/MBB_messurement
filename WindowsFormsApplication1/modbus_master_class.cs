using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Runtime.InteropServices;

namespace MBB_8_1_config
{

    public class modbus_master_class
    {

        // Position field in request
                private Form1 my_form;
        //Timer for timeout response
                private System.Timers.Timer TimerTimeout = new System.Timers.Timer();
       //Timer for time interval request
                private System.Timers.Timer TimerTimeRequest = new System.Timers.Timer();
                private System.IO.Ports.SerialPort SerialPortModbus;       
                private Thread read_modbus_data_thread; // Modbus thread 

     // -------------------------------MODBUS MESSAGE DIFINITION-----------------

                private const int SizeRequest = 8;
                // Position field in request
                private const int PosReqAddress = 0;
                private const int PosReqFunction = 1;
                private const int PosReqAddressData = 2;
                private const int PosReqNumData = 4;
                private const int PosReqCRC = 6;
                // Position field in response
                private const int PosResAddress = 0;
                private const int PosResFunction = 1;
                private const int PosResByteCount = 2;
                private const int PosResData = 3;
                 // reques paramiters
                private Dictionary<String, List<UInt16>> RequestList = new Dictionary<String, List<UInt16>>
                 {
                    {"AddressDev",new List<UInt16>{}},
                    {"Function",new List<UInt16>{}},
                    {"AddressData",new List<UInt16>{}},
                    {"NumData",new List<UInt16>{}}
                 };
                // callback function list
                private List<modbus_master_callback> modbus_master_f_callbak=new List<modbus_master_callback>();
                // counter request (used in create next request function )
                private int RequestCounter;
                // Temp callbac function
                modbus_master_callback reques_callbak_temp;
                // Temp byte request counter
                int byte_counter_temp;    
                private bool TimeOutState;
                private bool TimeRequestState;

        // -------------Modbus_class constructor-----------------
                public modbus_master_class(Form1 my_form_1, System.IO.Ports.SerialPort PortModbus, int Timeout, int TimeIntervalRequest)
                {
                    RequestCounter=0;
                    TimeOutState = true;
                    my_form = my_form_1;
                    SerialPortModbus = PortModbus; 
                    TimerTimeout.Elapsed += processing_modbus_timeout;                   
                    TimerTimeRequest.Elapsed += processing_modbus_time_request;
                    TimerTimeout.Interval = Timeout;
                    TimerTimeRequest.Interval = TimeIntervalRequest;
                     //run Modbus thread
                    read_modbus_data_thread = new Thread(processing_modbus_master);
                    read_modbus_data_thread.Start(); // start new thread
                }

        // --------------Add new request ----------------
                public void modbus_master_add_request(UInt16 InAddressDev,
                                                      UInt16 InFunction,
                                                      UInt16 InAddressData,
                                                      UInt16 InNumData,
                                                      modbus_master_callback callback_fun) 
                {
                    // Add new reques paramiters
                    RequestList["AddressDev"].Add(InAddressDev);
                    RequestList["Function"].Add(InFunction);
                    RequestList["AddressData"].Add(InAddressData);
                    RequestList["NumData"].Add(InNumData);
                    //Add callback function
                    modbus_master_f_callbak.Add(callback_fun);
                }



         // --------------Create next request from RequestList ----------------
                private bool processing_modbus_create_request(ref int req_num,ref byte[] request) {
                    UInt16 CRCRequest;
                    byte[] buff_convert;
                    //if no request data
                    if (RequestList["AddressDev"].Count == 0) { return false; }

                    request[PosReqAddress]     = Convert.ToByte(RequestList["AddressDev"][RequestCounter]);
                    request[PosReqFunction]    = Convert.ToByte(RequestList["Function"][RequestCounter]);
                    // fill field AddressData
                    buff_convert = BitConverter.GetBytes(RequestList["AddressData"][RequestCounter]);
                    request[PosReqAddressData] = buff_convert[1];
                    request[PosReqAddressData+1] = buff_convert[0];
                    // fill field NumData
                    buff_convert = BitConverter.GetBytes(RequestList["NumData"][RequestCounter]);
                    request[PosReqNumData] = buff_convert[1];
                    request[PosReqNumData + 1] = buff_convert[0];
                    // fill field NumData
                    CRCRequest = CRC16(ref request, 6);
                    buff_convert = BitConverter.GetBytes(CRCRequest);
                    request[PosReqCRC] = buff_convert[1];
                    request[PosReqCRC + 1] = buff_convert[0];
                    //take request callback function
                    reques_callbak_temp = modbus_master_f_callbak[RequestCounter];
                    //take byte counter
                    byte_counter_temp = RequestList["NumData"][RequestCounter] * 2;
                    req_num = RequestCounter;

                    RequestCounter++;
                    if (RequestCounter >= RequestList["NumData"].Count()) 
                    {
                        RequestCounter = 0;
                    }
                    return true;
                }

        void processing_modbus_master()
        {
            bool f_finde_start;
            int req_number = 0;
            byte[] request_buff = new byte[SizeRequest];
            byte[] response_buff = new byte[256];

            while (true) // infinity loop read/wreate com port
            {


                // If need close thread
                if (!(my_form.f_COM_is_open))
                {
                    this.stop_read_com_strem();
                    return;
                }

                //created request
                if (!processing_modbus_create_request(ref req_number, ref request_buff)) { continue; };
                // Tx Request
                my_form.write_com(SizeRequest, ref request_buff, 0, SerialPortModbus);
                // start Rx response
                TimerTimeout.Start();
                TimerTimeRequest.Start();
                TimeOutState = true;
                TimeRequestState = false;
                f_finde_start = false;
                // try read port while before timeout event OR read correct response
                while (TimeOutState) { 
                    if (!f_finde_start) {  //  start response (firest N bytes) still not find
                        if (!my_form.read_com(1, ref response_buff, PosResByteCount, SerialPortModbus)) { continue; };
                        if((response_buff[PosResAddress]==request_buff[PosReqAddress])&&
                           (response_buff[PosResFunction]==request_buff[PosReqFunction])&&
                           (response_buff[PosResByteCount]==Convert.ToByte(byte_counter_temp)))
                        {
                            f_finde_start = true;
                            continue;
                        }
                        //shift 2 byte from 2-position 
                        //Array.Copy(response_buff, 1, response_buff, 0, 2);
                        response_buff[0] = response_buff[1];
                        response_buff[1] = response_buff[2];

                    }
                    else {
                        //read payload. 2 byte - CRC
                        if (my_form.read_com(byte_counter_temp+2, ref response_buff, 0, SerialPortModbus)) {
                            // if read sucsessful conver data in normal sequence and call callbac function
                            modbus_master_data_conv(ref  response_buff);
                            reques_callbak_temp(req_number, ref response_buff);
                            while (!TimeRequestState) { Thread.Sleep(2); } // waite time request interval
                            break;

                        }
                        Thread.Sleep(1);
                        continue;                       
                    }               
                }
            }
        } // конец void read_modbus_data() 


        private void modbus_master_data_conv(ref byte[] data_array) { 
            int counter;
            byte temp_data;
            for(counter=0;counter<data_array.Length;counter+=2){
                temp_data = data_array[counter];
                data_array[counter] = data_array[counter+1];
                data_array[counter + 1] = temp_data;
            }
        
        }


        // Event for Timeout response 
        private void processing_modbus_timeout(object sender, System.Timers.ElapsedEventArgs e)
        {
            TimerTimeout.Stop();
            TimeOutState = false;
        }

        // Event for Time interval rwques 
        private void processing_modbus_time_request(object sender, System.Timers.ElapsedEventArgs e)
        {
            TimerTimeRequest.Stop();
            TimeRequestState = true;
        }

        // --------------метод stop_read_com_strem-------------------
        // метод stop_read_com_strem - отсановка потока экземпляра класа Modbus_clas
        public void stop_read_com_strem()
        {
            read_modbus_data_thread.Abort();  // Останавливаем поток
        }

        //======================================================================================
        //===============МЕТОДЫ РАСЧЕТА КОНТРОЛЬНОЙ СУММЫ CRC16=================================
        //================================НАЧАЛО================================================

        Byte[] auchCRCHi = new Byte[]{

		0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41, 0x00,
		0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40, 0x00,
		0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41, 0x00,
		0xC1, 0x81, 0x40, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x00,
		0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41, 0x00,
		0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40, 0x00,
		0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40, 0x01,
		0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40, 0x00,
		0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41, 0x00,
		0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40, 0x00,
		0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41, 0x00,
		0xC1, 0x81, 0x40, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x00,
		0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41, 0x00,
		0xC1, 0x81, 0x40, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01,
		0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x00,
		0xC1, 0x81, 0x40, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x00,
		0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41, 0x00,
		0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40, 0x00,
		0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41, 0x00,
		0xC1, 0x81, 0x40, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x00,
		0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41, 0x00,
		0xC1, 0x81, 0x40 
        };

        Byte[] auchCRCLo = new Byte[]{ 0x00, 0xC0, 0xC1, 0x01, 0xC3, 0x03, 0x02, 0xC2,
		0xC6, 0x06, 0x07, 0xC7, 0x05, 0xC5, 0xC4, 0x04, 0xCC, 0x0C, 0x0D, 0xCD,
		0x0F, 0xCF, 0xCE, 0x0E, 0x0A, 0xCA, 0xCB, 0x0B, 0xC9, 0x09, 0x08, 0xC8,
		0xD8, 0x18, 0x19, 0xD9, 0x1B, 0xDB, 0xDA, 0x1A, 0x1E, 0xDE, 0xDF, 0x1F,
		0xDD, 0x1D, 0x1C, 0xDC, 0x14, 0xD4, 0xD5, 0x15, 0xD7, 0x17, 0x16, 0xD6,
		0xD2, 0x12, 0x13, 0xD3, 0x11, 0xD1, 0xD0, 0x10, 0xF0, 0x30, 0x31, 0xF1,
		0x33, 0xF3, 0xF2, 0x32, 0x36, 0xF6, 0xF7, 0x37, 0xF5, 0x35, 0x34, 0xF4,
		0x3C, 0xFC, 0xFD, 0x3D, 0xFF, 0x3F, 0x3E, 0xFE, 0xFA, 0x3A, 0x3B, 0xFB,
		0x39, 0xF9, 0xF8, 0x38, 0x28, 0xE8, 0xE9, 0x29, 0xEB, 0x2B, 0x2A, 0xEA,
		0xEE, 0x2E, 0x2F, 0xEF, 0x2D, 0xED, 0xEC, 0x2C, 0xE4, 0x24, 0x25, 0xE5,
		0x27, 0xE7, 0xE6, 0x26, 0x22, 0xE2, 0xE3, 0x23, 0xE1, 0x21, 0x20, 0xE0,
		0xA0, 0x60, 0x61, 0xA1, 0x63, 0xA3, 0xA2, 0x62, 0x66, 0xA6, 0xA7, 0x67,
		0xA5, 0x65, 0x64, 0xA4, 0x6C, 0xAC, 0xAD, 0x6D, 0xAF, 0x6F, 0x6E, 0xAE,
		0xAA, 0x6A, 0x6B, 0xAB, 0x69, 0xA9, 0xA8, 0x68, 0x78, 0xB8, 0xB9, 0x79,
		0xBB, 0x7B, 0x7A, 0xBA, 0xBE, 0x7E, 0x7F, 0xBF, 0x7D, 0xBD, 0xBC, 0x7C,
		0xB4, 0x74, 0x75, 0xB5, 0x77, 0xB7, 0xB6, 0x76, 0x72, 0xB2, 0xB3, 0x73,
		0xB1, 0x71, 0x70, 0xB0, 0x50, 0x90, 0x91, 0x51, 0x93, 0x53, 0x52, 0x92,
		0x96, 0x56, 0x57, 0x97, 0x55, 0x95, 0x94, 0x54, 0x9C, 0x5C, 0x5D, 0x9D,
		0x5F, 0x9F, 0x9E, 0x5E, 0x5A, 0x9A, 0x9B, 0x5B, 0x99, 0x59, 0x58, 0x98,
		0x88, 0x48, 0x49, 0x89, 0x4B, 0x8B, 0x8A, 0x4A, 0x4E, 0x8E, 0x8F, 0x4F,
		0x8D, 0x4D, 0x4C, 0x8C, 0x44, 0x84, 0x85, 0x45, 0x87, 0x47, 0x46, 0x86,
		0x82, 0x42, 0x43, 0x83, 0x41, 0x81, 0x80, 0x40 
        };

        private UInt16 CRC16(ref Byte[] puchMsg, int usDatalen)
        {
            Byte uIndex;
            Byte uchCRCHi = 0xFF;
            Byte uchCRCLo = 0xFF;
            Int16 counter = 0;
            for (counter = 0; counter < usDatalen; counter++)
            {
                uIndex = (Byte)(uchCRCHi ^ puchMsg[counter]);
                uchCRCHi = (Byte)(uchCRCLo ^ auchCRCHi[uIndex]);
                uchCRCLo = auchCRCLo[uIndex];
            }
            return ((UInt16)((UInt16)uchCRCLo  | (UInt16)uchCRCHi << 8));
        }
        


        //============================КОНЕЦ====================================================
        //===============МЕТОДЫ РАСЧЕТА КОНТРОЛЬНОЙ СУММЫ CRC16=================================
        //======================================================================================



    } // конец modbus_class






}  // конец namespace
