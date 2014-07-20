using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetherTear.Framework.GameObjects;

namespace NetherTear.Framework.Control
{
    class MainGameController : ControllerBase
    {
        private Player player;

        public MainGameController(Player player)
        {
            this.player = player;
        }

        #region Public Methods
        public void SetPlayerMovementDirection(PlayerAction direction)
        {
            switch(direction)
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
        #endregion

        #region Private Methods
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

    public enum PlayerAction
    {
        Up,
        Down,
        Left,
        Right
    }
}
