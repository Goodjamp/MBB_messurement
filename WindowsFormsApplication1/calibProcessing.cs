using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MBB_8_1_config
{
    class calibProcessing 
    {
        List<List<double>> globRezMes;
        double k_line, b_line;
        int maxNumberTempData;
        int counterTempData;
        Mutex mutexProtectAxccess = new Mutex();

        const double maxCurrentDiff = 200;
        
        //position and list of current mes data
        const int posVoltmeter = 0;
        const int posMBB = 1;
        const int posCurrent = 0;
        const int posCode = 1;
        List<double[]> tempRezMes = new List<double[]>();  

        public calibProcessing(int inMaxNumberTempData)
        {
            if (inMaxNumberTempData <= 0)
            {
                return;
            }
            
            globRezMes = new List<List<double>>();
        }



        public void calibSetMaxNumberTempData(int inMaxNumberTempData)
        {
            mutexProtectAxccess.WaitOne();
            if (inMaxNumberTempData <= 0) 
            {
                mutexProtectAxccess.ReleaseMutex();
                return;
            }
            maxNumberTempData = inMaxNumberTempData;
            mutexProtectAxccess.ReleaseMutex();
        }



        public void addNewData(int reqNumber, double rezMes, double rezCode) 
        {
            mutexProtectAxccess.WaitOne();
            // if calibration on one point complite - waite next point 
            if (counterTempData >= maxNumberTempData) 
            {
                mutexProtectAxccess.ReleaseMutex();
                return; 
            }
            //data from voltmeter
            if (reqNumber == 0) 
            {
                tempRezMes.Clear();
            }
            else if (reqNumber == 1) // data from MBB
            {
                if (tempRezMes.Count == 0)
                {
                    mutexProtectAxccess.ReleaseMutex();
                    return;
                }
            }
            else 
            {
                tempRezMes.Clear();
                if (tempRezMes.Count == 0)
                {
                    mutexProtectAxccess.ReleaseMutex();
                    return;
                }
            }
            //add new data
            tempRezMes.Add(new double[2]);
            tempRezMes.ElementAt(tempRezMes.Count - 1)[posCurrent] = rezMes;
            tempRezMes.ElementAt(tempRezMes.Count - 1)[posCode] = rezCode;
            if (tempRezMes.Count < 2)  
            {
                mutexProtectAxccess.ReleaseMutex();
                return;
            }
            if ((tempRezMes.ElementAt(posVoltmeter)[posCurrent] - tempRezMes.ElementAt(posVoltmeter)[posVoltmeter]) > maxCurrentDiff) 
            {
                tempRezMes.Clear();
                mutexProtectAxccess.ReleaseMutex();
                return;
            }
            // Add new data to the global list
            globRezMes.Add(new List<double>());
            globRezMes.ElementAt(globRezMes.Count - 1).Add(tempRezMes.ElementAt(posMBB)[posCode]);
            globRezMes.ElementAt(globRezMes.Count - 1).Add(tempRezMes.ElementAt(posVoltmeter)[posCurrent]);
            //
            counterTempData++;
            tempRezMes.Clear();
            mutexProtectAxccess.ReleaseMutex();
        }

        //
        public void resetTempCounter()
        {
            mutexProtectAxccess.WaitOne();
            counterTempData = 0;
            mutexProtectAxccess.ReleaseMutex();
        }

        //
        public void calcLineCoef()
        {
            mutexProtectAxccess.WaitOne();
            double sumX = 0, 
                   sumY = 0, 
                   sumXY =0 , 
                   sumX2 = 0;
            int nData = globRezMes.Count;

            foreach (List<double> oneData in globRezMes) 
            {
                sumX = sumX + oneData.ElementAt(0);
                sumY = sumY + oneData.ElementAt(1);
                sumX2 = sumX2 + oneData.ElementAt(0) * oneData.ElementAt(0);
                sumXY = sumXY + oneData.ElementAt(0) * oneData.ElementAt(1);
            }

            // calculate line paramiters
            k_line = (nData * sumXY - sumX * sumY) / (nData * sumX2 - sumX * sumX);
            b_line = (sumY - k_line * sumX) / (nData);
            mutexProtectAxccess.ReleaseMutex();
        }

        // Get line coefficient
        public void calcLineCoef(ref double kLineCoef, ref double bLineCoef) 
        {
            kLineCoef = k_line;
            bLineCoef = b_line;
        }

    }
}
