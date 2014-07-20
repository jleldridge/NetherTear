using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetherTear.Framework.Control;

namespace NetherTear.Framework.Config
{
    public abstract class ControllerConfigBase
    {
        public abstract void RestoreDefaults();
    }

    public enum KeyboardKey
    {
        Q, W, E, R, T, Y, U, I, O, P,
        A, S, D, F, G, H, J, K, L,
        X, C, V, B, N, M,
        UP_ARROW, DOWN_ARROW,
        LEFT_ARROW, RIGHT_ARROW
    }
}
