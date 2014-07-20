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
        private List<Keys> mappedKeys;
        private readonly Dictionary<Keys, UserInput> KeysToUserInputMap =
            new Dictionary<Keys, UserInput>()
        {
            {Keys.A, UserInput.A}, {Keys.B, UserInput.B}, {Keys.C, UserInput.C},
            {Keys.D, UserInput.D}, {Keys.E, UserInput.E}, {Keys.F, UserInput.F},
            {Keys.G, UserInput.G}, {Keys.H, UserInput.H}, {Keys.I, UserInput.I},
            {Keys.J, UserInput.J}, {Keys.K, UserInput.K}, {Keys.L, UserInput.L},
            {Keys.M, UserInput.M}, {Keys.O, UserInput.O}, {Keys.P, UserInput.P},
            {Keys.Q, UserInput.Q}, {Keys.R, UserInput.R}, {Keys.S, UserInput.S},
            {Keys.T, UserInput.T}, {Keys.U, UserInput.U}, {Keys.V, UserInput.V},
            {Keys.W, UserInput.W}, {Keys.X, UserInput.X}, {Keys.Y, UserInput.Y},
            {Keys.Z, UserInput.Z}, 
            {Keys.Left, UserInput.LeftArrow}, {Keys.Right, UserInput.RightArrow},
            {Keys.Up, UserInput.UpArrow}, {Keys.Down, UserInput.DownArrow}
        };
        #endregion

        #region Public Variables
        public ControllerBase Controller;
        #endregion

        #region Constructors
        public UserInputHandler(ControllerBase controller)
        {
            this.Controller = controller;
            this.mappedKeys = GetMappedKeys();
        }
        #endregion

        #region Public Methods
        
        
        public void HandleUserInput()
        {
            KeyboardState kbState = Keyboard.GetState();
            GamePadState gpState = GamePad.GetState(PlayerIndex.One);

            var keysDown = new List<UserInput>();
            var keysUp = new List<UserInput>();

            foreach (var key in mappedKeys)
            {
                if (kbState.IsKeyDown(key))
                {
                    keysDown.Add(KeysToUserInputMap[key]);
                }
                else
                {
                    keysUp.Add(KeysToUserInputMap[key]);
                }
                Controller.HandleUserInput(keysUp, keysDown);
            }
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Gets the keys that are currently mapped to actions in the game.
        /// </summary>
        /// <returns>A list of Keys that are currently mapped in the game.
        /// </returns>
        private List<Keys> GetMappedKeys()
        {
            var mappedKeys = new List<Keys>();
            var mappedUserInput = Controller.GetMappedUserInput();

            foreach (var kvp in KeysToUserInputMap)
            {
                if (mappedUserInput.Contains(kvp.Value))
                {
                    mappedKeys.Add(kvp.Key);
                }
            }

            return mappedKeys;
        }
        #endregion
    }
}
