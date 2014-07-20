using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetherTear.Framework.GameObjects;
using NetherTear.Framework.Config;

namespace NetherTear.Framework.Control
{
    class MainGameController : ControllerBase
    {
        #region Private Variables
        private Player player;
        #endregion

        #region Public Variables
        public MainGameControllerConfig Config { get; set; }
        #endregion

        public MainGameController(Player player)
        {
            this.player = player;
            Config = new MainGameControllerConfig();
        }

        #region Public Methods
        public override void HandleUserInput(UserInput input)
        {
            ReadyPlayerForInput();
            if (input != UserInput.Null && Config[input] != PlayerAction.Null)
            {
                HandleUserInput(Config[input]);
            }
        }
        #endregion

        #region Private Methods
        private void HandleUserInput(PlayerAction action)
        {
            switch(action)
            {
                case PlayerAction.Up:
                    StartMovingPlayerUp();
                    break;
                case PlayerAction.Down:
                    StartMovingPlayerDown();
                    break;
                case PlayerAction.Left:
                    StartMovingPlayerLeft();
                    break;
                case PlayerAction.Right:
                    StartMovingPlayerRight();
                    break;
            }
        }

        private void ReadyPlayerForInput()
        {
            player.XSpeed = 0;
            player.YSpeed = 0;
        }

        private void StartMovingPlayerUp()
        {
            player.YSpeed = player.MaxYSpeed * -1;
        }

        private void StartMovingPlayerDown()
        {
            player.YSpeed = player.MaxYSpeed;
        }

        private void StartMovingPlayerLeft()
        {
            player.XSpeed = player.MaxXSpeed * -1;
        }

        private void StartMovingPlayerRight()
        {
            player.XSpeed = player.MaxXSpeed;
        }
        #endregion
    }
}
