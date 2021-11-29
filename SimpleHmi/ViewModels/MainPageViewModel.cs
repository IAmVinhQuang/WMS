using Prism.Commands;
using Prism.Mvvm;
using SimpleHmi.PlcService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleHmi.ViewModels
{
    class MainPageViewModel : BindableBase
    {
        public string IpAddress
        {
            get { return _ipAddress; }
            set { SetProperty(ref _ipAddress, value); }
        }
        private string _ipAddress;
        public bool R121
        {
            get { return _r121; }
            set { SetProperty(ref _r121, value); }
        }
        private bool _r121;
        public bool R122
        {
            get { return _r122; }
            set { SetProperty(ref _r122, value); }
        }
        private bool _r122;
        public bool R123
        {
            get { return _r123; }
            set { SetProperty(ref _r123, value); }
        }
        private bool _r123;
        public bool R124
        {
            get { return _r124; }
            set { SetProperty(ref _r124, value); }
        }
        private bool _r124;
        public bool R125
        {
            get { return _r125; }
            set { SetProperty(ref _r125, value); }
        }
        private bool _r125;
        public bool R126
        {
            get { return _r126; }
            set { SetProperty(ref _r126, value); }
        }
        private bool _r126;
        public bool R127
        {
            get { return _r127; }
            set { SetProperty(ref _r127, value); }
        }
        private bool _r127;
        public bool R128
        {
            get { return _r128; }
            set { SetProperty(ref _r128, value); }
        }
        private bool _r128;
        public bool R129
        {
            get { return _r129; }
            set { SetProperty(ref _r129, value); }
        }
        private bool _r129;
        public bool R1210
        {
            get { return _r1210; }
            set { SetProperty(ref _r1210, value); }
        }
        private bool _r1210;
        public bool R1211
        {
            get { return _r1211; }
            set { SetProperty(ref _r1211, value); }
        }
        private bool _r1211;
        public bool R1212
        {
            get { return _r1212; }
            set { SetProperty(ref _r1212, value); }
        }
        private bool _r1212;
        public bool R1213
        {
            get { return _r1213; }
            set { SetProperty(ref _r1213, value); }
        }
        private bool _r1213;
        public bool R1214
        {
            get { return _r1214; }
            set { SetProperty(ref _r1214, value); }
        }
        private bool _r1214;
        public bool R1215
        {
            get { return _r1215; }
            set { SetProperty(ref _r1215, value); }
        }
        private bool _r1215;
        public bool R1216
        {
            get { return _r1216; }
            set { SetProperty(ref _r1216, value); }
        }
        private bool _r1216;
        public bool R1217
        {
            get { return _r1217; }
            set { SetProperty(ref _r1217, value); }
        }
        private bool _r1217;
        public bool R1218
        {
            get { return _r1218; }
            set { SetProperty(ref _r1218, value); }
        }
        private bool _r1218;
        public bool R111
        {
            get { return _r111; }
            set { SetProperty(ref _r111, value); }
        }
        private bool _r111;
        public bool R112
        {
            get { return _r112; }
            set { SetProperty(ref _r112, value); }
        }
        private bool _r112;
        public bool R113
        {
            get { return _r113; }
            set { SetProperty(ref _r113, value); }
        }
        private bool _r113;
        public bool R114
        {
            get { return _r114; }
            set { SetProperty(ref _r114, value); }
        }
        private bool _r114;
        public bool R115
        {
            get { return _r115; }
            set { SetProperty(ref _r115, value); }
        }
        private bool _r115;
        public bool R116
        {
            get { return _r116; }
            set { SetProperty(ref _r116, value); }
        }
        private bool _r116;
        public bool R117
        {
            get { return _r117; }
            set { SetProperty(ref _r117, value); }
        }
        private bool _r117;
        public bool R118
        {
            get { return _r118; }
            set { SetProperty(ref _r118, value); }
        }
        private bool _r118;
        public bool R119
        {
            get { return _r119; }
            set { SetProperty(ref _r119, value); }
        }
        private bool _r119;
        public bool R1110
        {
            get { return _r1110; }
            set { SetProperty(ref _r1110, value); }
        }
        private bool _r1110;
        public bool R1111
        {
            get { return _r1111; }
            set { SetProperty(ref _r1111, value); }
        }
        private bool _r1111;
        public bool R1112
        {
            get { return _r1112; }
            set { SetProperty(ref _r1112, value); }
        }
        private bool _r1112;
        public bool R1113
        {
            get { return _r1113; }
            set { SetProperty(ref _r1113, value); }
        }
        private bool _r1113;
        public bool R1114
        {
            get { return _r1114; }
            set { SetProperty(ref _r1114, value); }
        }
        private bool _r1114;
        public bool R1115
        {
            get { return _r1115; }
            set { SetProperty(ref _r1115, value); }
        }
        private bool _r1115;
        public bool R1116
        {
            get { return _r1116; }
            set { SetProperty(ref _r1116, value); }
        }
        private bool _r1116;
        public bool R1117
        {
            get { return _r1117; }
            set { SetProperty(ref _r1117, value); }
        }
        private bool _r1117;
        public bool R1118
        {
            get { return _r1118; }
            set { SetProperty(ref _r1118, value); }
        }
        private bool _r1118;
        public bool R131
        {
            get { return _r131; }
            set { SetProperty(ref _r131, value); }
        }
        private bool _r131;
        public bool R132
        {
            get { return _r132; }
            set { SetProperty(ref _r132, value); }
        }
        private bool _r132;
        public bool R133
        {
            get { return _r133; }
            set { SetProperty(ref _r133, value); }
        }
        private bool _r133;
        public bool R134
        {
            get { return _r134; }
            set { SetProperty(ref _r134, value); }
        }
        private bool _r134;
        public bool R135
        {
            get { return _r135; }
            set { SetProperty(ref _r135, value); }
        }
        private bool _r135;
        public bool R136
        {
            get { return _r136; }
            set { SetProperty(ref _r136, value); }
        }
        private bool _r136;
        public bool R137
        {
            get { return _r137; }
            set { SetProperty(ref _r137, value); }
        }
        private bool _r137;
        public bool R138
        {
            get { return _r138; }
            set { SetProperty(ref _r138, value); }
        }
        private bool _r138;
        public bool R139
        {
            get { return _r139; }
            set { SetProperty(ref _r139, value); }
        }
        private bool _r139;
        public bool R1310
        {
            get { return _r1310; }
            set { SetProperty(ref _r1310, value); }
        }
        private bool _r1310;
        public bool R1311
        {
            get { return _r1311; }
            set { SetProperty(ref _r1311, value); }
        }
        private bool _r1311;
        public bool R1312
        {
            get { return _r1312; }
            set { SetProperty(ref _r1312, value); }
        }
        private bool _r1312;
        public bool R1313
        {
            get { return _r1313; }
            set { SetProperty(ref _r1313, value); }
        }
        private bool _r1313;
        public bool R1314
        {
            get { return _r1314; }
            set { SetProperty(ref _r1314, value); }
        }
        private bool _r1314;
        public bool R1315
        {
            get { return _r1315; }
            set { SetProperty(ref _r1315, value); }
        }
        private bool _r1315;
        public bool R1316
        {
            get { return _r1316; }
            set { SetProperty(ref _r1316, value); }
        }
        private bool _r1316;
        public bool R1317
        {
            get { return _r1317; }
            set { SetProperty(ref _r1317, value); }
        }
        private bool _r1317;
        public bool R1318
        {
            get { return _r1318; }
            set { SetProperty(ref _r1318, value); }
        }
        private bool _r1318;
        public bool R141
        {
            get { return _r141; }
            set { SetProperty(ref _r141, value); }
        }
        private bool _r141;
        public bool R142
        {
            get { return _r142; }
            set { SetProperty(ref _r142, value); }
        }
        private bool _r142;
        public bool R143
        {
            get { return _r143; }
            set { SetProperty(ref _r143, value); }
        }
        private bool _r143;
        public bool R144
        {
            get { return _r144; }
            set { SetProperty(ref _r144, value); }
        }
        private bool _r144;
        public bool R145
        {
            get { return _r145; }
            set { SetProperty(ref _r145, value); }
        }
        private bool _r145;
        public bool R146
        {
            get { return _r146; }
            set { SetProperty(ref _r146, value); }
        }
        private bool _r146;
        public bool R147
        {
            get { return _r147; }
            set { SetProperty(ref _r147, value); }
        }
        private bool _r147;
        public bool R148
        {
            get { return _r148; }
            set { SetProperty(ref _r148, value); }
        }
        private bool _r148;
        public bool R149
        {
            get { return _r149; }
            set { SetProperty(ref _r149, value); }
        }
        private bool _r149;
        public bool R1410
        {
            get { return _r1410; }
            set { SetProperty(ref _r1410, value); }
        }
        private bool _r1410;
        public bool R1411
        {
            get { return _r1411; }
            set { SetProperty(ref _r1411, value); }
        }
        private bool _r1411;
        public bool R1412
        {
            get { return _r1412; }
            set { SetProperty(ref _r1412, value); }
        }
        private bool _r1412;
        public bool R1413
        {
            get { return _r1413; }
            set { SetProperty(ref _r1413, value); }
        }
        private bool _r1413;
        public bool R1414
        {
            get { return _r1414; }
            set { SetProperty(ref _r1414, value); }
        }
        private bool _r1414;
        public bool R1415
        {
            get { return _r1415; }
            set { SetProperty(ref _r1415, value); }
        }
        private bool _r1415;
        public bool R1416
        {
            get { return _r1416; }
            set { SetProperty(ref _r1416, value); }
        }
        private bool _r1416;
        public bool R1417
        {
            get { return _r1417; }
            set { SetProperty(ref _r1417, value); }
        }
        private bool _r1417;
        public bool R1418
        {
            get { return _r1418; }
            set { SetProperty(ref _r1418, value); }
        }
        private bool _r1418;
        public bool R151
        {
            get { return _r151; }
            set { SetProperty(ref _r151, value); }
        }
        private bool _r151;
        public bool R152
        {
            get { return _r152; }
            set { SetProperty(ref _r152, value); }
        }
        private bool _r152;
        public bool R153
        {
            get { return _r153; }
            set { SetProperty(ref _r153, value); }
        }
        private bool _r153;
        public bool R154
        {
            get { return _r154; }
            set { SetProperty(ref _r154, value); }
        }
        private bool _r154;
        public bool R155
        {
            get { return _r155; }
            set { SetProperty(ref _r155, value); }
        }
        private bool _r155;
        public bool R156
        {
            get { return _r156; }
            set { SetProperty(ref _r156, value); }
        }
        private bool _r156;
        public bool R157
        {
            get { return _r157; }
            set { SetProperty(ref _r157, value); }
        }
        private bool _r157;
        public bool R158
        {
            get { return _r158; }
            set { SetProperty(ref _r158, value); }
        }
        private bool _r158;
        public bool R159
        {
            get { return _r159; }
            set { SetProperty(ref _r159, value); }
        }
        private bool _r159;
        public bool R1510
        {
            get { return _r1510; }
            set { SetProperty(ref _r1510, value); }
        }
        private bool _r1510;
        public bool R1511
        {
            get { return _r1511; }
            set { SetProperty(ref _r1511, value); }
        }
        private bool _r1511;
        public bool R1512
        {
            get { return _r1512; }
            set { SetProperty(ref _r1512, value); }
        }
        private bool _r1512;
        public bool R1513
        {
            get { return _r1513; }
            set { SetProperty(ref _r1513, value); }
        }
        private bool _r1513;
        public bool R1514
        {
            get { return _r1514; }
            set { SetProperty(ref _r1514, value); }
        }
        private bool _r1514;
        public bool R1515
        {
            get { return _r1515; }
            set { SetProperty(ref _r1515, value); }
        }
        private bool _r1515;
        public bool R1516
        {
            get { return _r1516; }
            set { SetProperty(ref _r1516, value); }
        }
        private bool _r1516;
        public bool R1517
        {
            get { return _r1517; }
            set { SetProperty(ref _r1517, value); }
        }
        private bool _r1517;
        public bool R1518
        {
            get { return _r1518; }
            set { SetProperty(ref _r1518, value); }
        }
        private bool _r1518;
        public bool Motor1
        {
            get { return _motor1; }
            set { SetProperty(ref _motor1, value); }
        }
        private bool _motor1;
        public bool Motor2
        {
            get { return _motor2; }
            set { SetProperty(ref _motor2, value); }
        }
        private bool _motor2;
        public bool Motor3
        {
            get { return _motor3; }
            set { SetProperty(ref _motor3, value); }
        }
        private bool _motor3;
        public bool Motor4
        {
            get { return _motor4; }
            set { SetProperty(ref _motor4, value); }
        }
        private bool _motor4;
        public bool Motor5
        {
            get { return _motor5; }
            set { SetProperty(ref _motor5, value); }
        }
        private bool _motor5;
        public bool Motor6
        {
            get { return _motor6; }
            set { SetProperty(ref _motor6, value); }
        }
        private bool _motor6;
        public bool Motor7
        {
            get { return _motor7; }
            set { SetProperty(ref _motor7, value); }
        }
        private bool _motor7;
        public bool Motor8
        {
            get { return _motor8; }
            set { SetProperty(ref _motor8, value); }
        }
        private bool _motor8;
        public bool Motor9
        {
            get { return _motor9; }
            set { SetProperty(ref _motor9, value); }
        }
        private bool _motor9;
        public bool Motor10
        {
            get { return _motor10; }
            set { SetProperty(ref _motor10, value); }
        }
        private bool _motor10;
        public bool Motor11
        {
            get { return _motor11; }
            set { SetProperty(ref _motor11, value); }
        }
        private bool _motor11;
        public bool Motor12
        {
            get { return _motor12; }
            set { SetProperty(ref _motor12, value); }
        }
        private bool _motor12;
        public bool Motor13
        {
            get { return _motor13; }
            set { SetProperty(ref _motor13, value); }
        }
        private bool _motor13;
        public bool Motor14
        {
            get { return _motor14; }
            set { SetProperty(ref _motor14, value); }
        }
        private bool _motor14;
        public bool ModeAuto
        {
            get { return _modeAuto; }
            set { SetProperty(ref _modeAuto, value); }
        }
        private bool _modeAuto;
        public bool ModeMan
        {
            get { return _modeMan; }
            set { SetProperty(ref _modeMan, value); }
        }
        private bool _modeMan;
        public int OpenedAisle
        {
            get { return _openedAisle; }
            set { SetProperty(ref _openedAisle, value); }
        }
        private int _openedAisle;
       

        public ICommand ConnectCommand { get; private set; }

        public ICommand DisconnectCommand { get; private set; }

        

        IPlcService _plcService;

        public MainPageViewModel(IPlcService s7PlcService)
        {
            _plcService = s7PlcService;
            ConnectCommand = new DelegateCommand(Connect);
            DisconnectCommand = new DelegateCommand(Disconnect);
            IpAddress = "127.0.0.1";

            OnPlcServiceValuesRefreshed(null, null);
            _plcService.ValuesRefreshed += OnPlcServiceValuesRefreshed;
        }

        private void OnPlcServiceValuesRefreshed(object sender, EventArgs e)
        {           
            OpenedAisle = _plcService.OpenedAisle;
            R111 = _plcService.R111;
            R112 = _plcService.R112;
            R113 = _plcService.R113;
            R114 = _plcService.R114;
            R115 = _plcService.R115;
            R116 = _plcService.R116;
            R117 = _plcService.R117;
            R118 = _plcService.R118;
            R119 = _plcService.R119;
            R1110 = _plcService.R1110;
            R1111 = _plcService.R1111;
            R1112 = _plcService.R1112;
            R1113 = _plcService.R1113;
            R1114 = _plcService.R1114;
            R1115 = _plcService.R1115;
            R1116 = _plcService.R1116;
            R1117 = _plcService.R1117;
            R1118 = _plcService.R1118;

            R121 = _plcService.R121;
            R122 = _plcService.R122;
            R123 = _plcService.R123;
            R124 = _plcService.R124;
            R125 = _plcService.R125;
            R126 = _plcService.R126;
            R127 = _plcService.R127;
            R128 = _plcService.R128;
            R129 = _plcService.R129;
            R1210 = _plcService.R1210;
            R1211 = _plcService.R1211;
            R1212 = _plcService.R1212;
            R1213 = _plcService.R1213;
            R1214 = _plcService.R1214;
            R1215 = _plcService.R1215;
            R1216 = _plcService.R1216;
            R1217 = _plcService.R1217;
            R1218 = _plcService.R1218;

            R131 = _plcService.R131;
            R132 = _plcService.R132;
            R133 = _plcService.R133;
            R134 = _plcService.R134;
            R135 = _plcService.R135;
            R136 = _plcService.R136;
            R137 = _plcService.R137;
            R138 = _plcService.R138;
            R139 = _plcService.R139;
            R1310 = _plcService.R1310;
            R1311 = _plcService.R1311;
            R1312 = _plcService.R1312;
            R1313 = _plcService.R1313;
            R1314 = _plcService.R1314;
            R1315 = _plcService.R1315;
            R1316 = _plcService.R1316;
            R1317 = _plcService.R1317;
            R1318 = _plcService.R1318;

            R141 = _plcService.R141;
            R142 = _plcService.R142;
            R143 = _plcService.R143;
            R144 = _plcService.R144;
            R145 = _plcService.R145;
            R146 = _plcService.R146;
            R147 = _plcService.R147;
            R148 = _plcService.R148;
            R149 = _plcService.R149;
            R1410 = _plcService.R1410;
            R1411 = _plcService.R1411;
            R1412 = _plcService.R1412;
            R1413 = _plcService.R1413;
            R1414 = _plcService.R1414;
            R1415 = _plcService.R1415;
            R1416 = _plcService.R1416;
            R1417 = _plcService.R1417;
            R1418 = _plcService.R1418;

            R151 = _plcService.R151;
            R152 = _plcService.R152;
            R159 = _plcService.R159;
            R153 = _plcService.R153;
            R154 = _plcService.R154;
            R155 = _plcService.R155;
            R156 = _plcService.R156;
            R157 = _plcService.R157;
            R158 = _plcService.R158;
            R1510 = _plcService.R1510;
            R1511 = _plcService.R1511;
            R1512 = _plcService.R1512;
            R1513 = _plcService.R1513;
            R1514 = _plcService.R1514;
            R1515 = _plcService.R1515;
            R1516 = _plcService.R1516;
            R1517 = _plcService.R1517;
            R1518 = _plcService.R1518;

            Motor1 = _plcService.Motor1;
            Motor2 = _plcService.Motor2;
            Motor3 = _plcService.Motor3;
            Motor4 = _plcService.Motor4;
            Motor5 = _plcService.Motor5;
            Motor6 = _plcService.Motor6;
            Motor7 = _plcService.Motor7;
            Motor8 = _plcService.Motor8;
            Motor9 = _plcService.Motor9;
            Motor10 = _plcService.Motor10;
            Motor11 = _plcService.Motor11;
            Motor12 = _plcService.Motor12;
            Motor13 = _plcService.Motor13;
            Motor14 = _plcService.Motor14;

            ModeAuto = _plcService.ModeAuto;
            ModeMan = _plcService.ModeMan;

        }

        private void Connect()
        {
            _plcService.Connect(IpAddress, 0, 1);
        }

        private void Disconnect()
        {
            _plcService.Disconnect();
        }

       /* private async Task Start()
        {
            await _plcService.WriteStart();
        }

        private async Task Stop()
        {
            await _plcService.WriteStop();
        }*/
    }
}
