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
        private HashSet<PlayerAction> actionsDown = new HashSet<PlayerAction>();
        private PlayerAction lastXDirectionPressed = PlayerAction.Null;
        private PlayerAction lastYDirectionPressed = PlayerAction.Null;
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
        public override void HandleUserInput(List<UserInput> inputsUp, List<UserInput> inputsDown)
        {
            foreach (var input in inputsUp)
            {
                var action = Config[input];
                if (actionsDown.Contains(action))
                {
                    actionsDown.Remove(action);
                    if (lastXDirectionPressed == action)
                        lastXDirectionPressed = PlayerAction.Null;
                    else if (lastYDirectionPressed == action)
                        lastYDirectionPressed = PlayerAction.Null;
                }
            }

            foreach (var input in inputsDown)
            {
                var action = Config[input];
                
                if (!actionsDown.Contains(action))
                {
                    if (action == PlayerAction.Left || action == PlayerAction.Right)
                        lastXDirectionPressed = action;
                    else if (action == PlayerAction.Up || action == PlayerAction.Down)
                        lastYDirectionPressed = action;

                    actionsDown.Add(action);
                }

                if (lastXDirectionPressed == PlayerAction.Null)
                {
                    if (actionsDown.Contains(PlayerAction.Left))
                        lastXDirectionPressed = PlayerAction.Left;
                    else if (actionsDown.Contains(PlayerAction.Right))
                        lastXDirectionPressed = PlayerAction.Right;
                }
                if (lastYDirectionPressed == PlayerAction.Null)
                {
                    if (actionsDown.Contains(PlayerAction.Up))
                        lastYDirectionPressed = PlayerAction.Up;
                    else if (actionsDown.Contains(PlayerAction.Down))
                        lastYDirectionPressed = PlayerAction.Down;
                }
            }

            HandleUserInput();
        }

        public override List<UserInput> GetMappedUserInput()
        {
            return Config.GetMappedUserInput();
        }
        #endregion

        #region Private Methods
        private void HandleUserInput()
        {
            // handle X and Y movement in a way to minimize movement
            // stopping while switching keys
            if (lastXDirectionPressed == PlayerAction.Left)
                StartMovingPlayerLeft();
            else if (lastXDirectionPressed == PlayerAction.Right)
                StartMovingPlayerRight();
            else
                StopMovingPlayerX();
            if (lastYDirectionPressed == PlayerAction.Up)
                StartMovingPlayerUp();
            else if (lastYDirectionPressed == PlayerAction.Down)
                StartMovingPlayerDown();
            else
                StopMovingPlayerY();


            // todo: handle other player actions
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

        private void StopMovingPlayerX()
        {
            player.XSpeed = 0;
        }

        private void StopMovingPlayerY()
        {
            player.YSpeed = 0;
        }
        #endregion
    }
}
