using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using NetherTear.Framework.Control;
using NetherTear.Framework.Config;

namespace NetherTear.MonoGame.EventHandlers
{
    public class UserInputHandler
    {
        #region Private Variables
        #endregion

        #region Public Variables
        public ControllerBase Controller;
        #endregion

        #region Constructors
        public UserInputHandler(ControllerBase controller)
        {
            this.Controller = controller;
        }
        #endregion

        #region Public Methods
        public void HandleUserInput()
        {
            KeyboardState kbState = Keyboard.GetState();
            GamePadState gpState = GamePad.GetState(PlayerIndex.One);

            var keysPressed = kbState.GetPressedKeys();
            
            // if no keys are pressed we should still call HandleUser input to stop
            // the player from initiating/continuing any actions that require sustained
            // user input
            if (!keysPressed.Any())
            {
                Controller.HandleUserInput(UserInput.Null);
            }
            foreach (var key in keysPressed)
            {
                Controller.HandleUserInput(ConvertToUserInput(key));
            }
        }
        #endregion

        #region Private Methods
        private UserInput ConvertToUserInput(Keys key)
        {
            switch (key)
            {
                case Keys.Q:
                    return UserInput.Q;
                case Keys.W:
                    return UserInput.W;
                case Keys.E:
                    return UserInput.E;
                case Keys.R:
                    return UserInput.R;
                case Keys.T:
                    return UserInput.T;
                case Keys.Y:
                    return UserInput.Y;
                case Keys.U:
                    return UserInput.U;
                case Keys.I:
                    return UserInput.I;
                case Keys.O:
                    return UserInput.O;
                case Keys.P:
                    return UserInput.P;
                case Keys.A:
                    return UserInput.A;
                case Keys.S:
                    return UserInput.S;
                case Keys.D:
                    return UserInput.D;
                case Keys.F:
                    return UserInput.F;
                case Keys.G:
                    return UserInput.G;
                case Keys.H:
                    return UserInput.H;
                case Keys.J:
                    return UserInput.J;
                case Keys.K:
                    return UserInput.K;
                case Keys.L:
                    return UserInput.L;
                case Keys.Z:
                    return UserInput.Z;
                case Keys.X:
                    return UserInput.X;
                case Keys.C:
                    return UserInput.C;
                case Keys.V:
                    return UserInput.V;
                case Keys.B:
                    return UserInput.B;
                case Keys.N:
                    return UserInput.N;
                case Keys.M:
                    return UserInput.M;
                case Keys.Up:
                    return UserInput.UpArrow;
                case Keys.Down:
                    return UserInput.DownArrow;
                case Keys.Left:
                    return UserInput.LeftArrow;
                case Keys.Right:
                    return UserInput.RightArrow;
                default:
                    return UserInput.Null;
            }
        }
        #endregion
    }
}
