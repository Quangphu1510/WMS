using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS
{
    public class CGlobal
    {
        public static string Version = "1.0.0.0";
        public static SMachineInfor[] MachineInfor = new SMachineInfor[20];
        public static SQLiteDatabase DataBase = new SQLiteDatabase(@"T:\TPM-Phu\01.Database\wms.db");

        public static bool SimulationMode = false;
    }

    public struct SMachineInfor
    {
        public bool Enable;
        public SMaterialInfor[,] MaterialInfor;
        public SProdRate ProdRate;
        public eAMR_RQ AMRRequest;
    }
    public struct SMaterialInfor
    {
        public int Remain;
        public int Total;
    }
    public struct SProdRate
    {
        public int Input;
        public int Pass;
        public int Fail;
        public double TactTime;
    }

    enum eStage:int
    {
        ACT = 0,
        Sensor = 1,
    }
    enum eTray : int
    {
        Fail = 0,
        Input = 1,
    }
    public enum eAMR_RQ
    {
        None = 0,
        Request,
        Recieve,
        Error,
    }
}
