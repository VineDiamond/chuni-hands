using System.Collections.Generic;
using Interceptor;

namespace chuni_hands {
    internal class Keysdi {
        private static readonly Interceptor.Keys[] SensorMap = new Interceptor.Keys[] { Interceptor.Keys.Zero, Interceptor.Keys.O, Interceptor.Keys.L, Interceptor.Keys.P, Interceptor.Keys.CommaLeftArrow, Interceptor.Keys.PeriodRightArrow };
        public static void Send(IList<Sensor> sensors) {
            Input input = new Input();
            input.KeyboardFilterMode = KeyboardFilterMode.None;
            input.Load();
            for (var i = 0; i < 6; ++i) {
                if (sensors[i].Active) { input.SendKey(SensorMap[i],KeyState.Down); }
            else { input.SendKey(SensorMap[i], KeyState.Up); }
            }
            input.Unload();
        }


    }
}
