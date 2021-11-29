using System;
using System.Threading.Tasks;

namespace SimpleHmi.PlcService
{
    public interface IPlcService
    {
        ConnectionStates ConnectionState { get; }
        int OpenedAisle { get; }
        bool R111 { get; }
        bool R1110 { get; }
        bool R1111 { get; }
        bool R1112 { get; }
        bool R1113 { get; }
        bool R1114 { get; }
        bool R1115 { get; }
        bool R1116 { get; }
        bool R1117 { get; }
        bool R1118 { get; }
        bool R112 { get; }
        bool R113 { get; }
        bool R114 { get; }
        bool R115 { get; }
        bool R116 { get; }
        bool R117 { get; }
        bool R118 { get; }
        bool R119 { get; }
        bool R121 { get; }
        bool R1210 { get; }
        bool R1211 { get; }
        bool R1212 { get; }
        bool R1213 { get; }
        bool R1214 { get; }
        bool R1215 { get; }
        bool R1216 { get; }
        bool R1217 { get; }
        bool R1218 { get; }
        bool R122 { get; }
        bool R123 { get; }
        bool R124 { get; }
        bool R125 { get; }
        bool R126 { get; }
        bool R127 { get; }
        bool R128 { get; }
        bool R129 { get; }
        bool R131 { get; }
        bool R1310 { get; }
        bool R1311 { get; }
        bool R1312 { get; }
        bool R1313 { get; }
        bool R1314 { get; }
        bool R1315 { get; }
        bool R1316 { get; }
        bool R1317 { get; }
        bool R1318 { get; }
        bool R132 { get; }
        bool R133 { get; }
        bool R134 { get; }
        bool R135 { get; }
        bool R136 { get; }
        bool R137 { get; }
        bool R138 { get; }
        bool R139 { get; }
        bool R141 { get; }
        bool R1410 { get; }
        bool R1411 { get; }
        bool R1412 { get; }
        bool R1413 { get; }
        bool R1414 { get; }
        bool R1415 { get; }
        bool R1416 { get; }
        bool R1417 { get; }
        bool R1418 { get; }
        bool R142 { get; }
        bool R143 { get; }
        bool R144 { get; }
        bool R145 { get; }
        bool R146 { get; }
        bool R147 { get; }
        bool R148 { get; }
        bool R149 { get; }
        bool R151 { get; }
        bool R1510 { get; }
        bool R1511 { get; }
        bool R1512 { get; }
        bool R1513 { get; }
        bool R1514 { get; }
        bool R1515 { get; }
        bool R1516 { get; }
        bool R1517 { get; }
        bool R1518 { get; }
        bool R152 { get; }
        bool R153 { get; }
        bool R154 { get; }
        bool R155 { get; }
        bool R156 { get; }
        bool R157 { get; }
        bool R158 { get; }
        bool R159 { get; }
        bool Motor1 { get; }
        bool Motor2 { get; }
        bool Motor3 { get; }
        bool Motor4 { get; }
        bool Motor5 { get; }
        bool Motor6 { get; }
        bool Motor7 { get; }
        bool Motor8 { get; }
        bool Motor9 { get; }
        bool Motor10 { get; }
        bool Motor11 { get; }
        bool Motor12 { get; }
        bool Motor13 { get; }
        bool Motor14 { get; }
        bool ModeAuto { get; }
        bool ModeMan { get; }

        TimeSpan ScanTime { get; }

        event EventHandler ValuesRefreshed;

        void Connect(string ipAddress, int rack, int slot);
        void Disconnect();
        Task WriteButton();
        Task WriteButton(string address);
        Task WriteSpeedInletPump(short speed);
        Task WriteSpeedOutletPump(short speed);
    }
}