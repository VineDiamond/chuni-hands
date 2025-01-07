using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace chuni_hands {
    internal class Keys {
        private static readonly byte[] SensorMap = new byte[] { 0x30, 0x4F, 0x4C, 0x50, 0xBC, 0xBE };
        [DllImport("user32.dll", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);
        public const byte KeyUp = 0x02;
        public const byte Key = 0x4F;


        public static void Send(IList<Sensor> sensors) {
            for (var i = 0; i < 6; ++i) {
                if (sensors[i].Active) { keybd_event(SensorMap[i], 0, 0, 0); }
                else { keybd_event(SensorMap[i], 0, KeyUp, 0); }
            }
        }


    }
}
