using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetherTear.Framework.Config
{
    public abstract class ControllerConfigBase<T> where T : IConvertible
    {
        public abstract void RestoreDefaults();
        public abstract T this[UserInput key] { get; set; }
        public abstract List<UserInput> GetMappedUserInput();
    }

    public enum UserInput
    {
        // keyboard values
        Q, W, E, R, T, Y, U, I, O, P,
        A, S, D, F, G, H, J, K, L,
        Z, X, C, V, B, N, M,
        UpArrow, DownArrow,
        LeftArrow, RightArrow,
        // controller values
        ButtonA, ButtonX, ButtonY, ButtonB,
        DpadUp, DpadDown, DpadLeft, DpadRight,
        L1, L2, L3, R1, R2, R3,
        LeftStick, RightStick,
        Start, Select,
        // null
        Null
    }

    public enum PlayerAction
    {
        Up, Down, Left, Right,

        // null
        Null
    }
}
