using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetherTear.Framework.GameObjects;
using NetherTear.Framework.Control;

namespace NetherTear.Framework.Engine
{
    public class GameState
    {
        #region Public Variables
        public Player Player { get; set; }
        public ControllerBase Controller { get; set; }
        #endregion

        #region Constructors
        // this constructor should initialize a "New Game" gamestate
        public GameState()
        {
            this.Player = new Player(50, 50);
            Controller = new MainGameController(Player);
        }

        // todo: need a constructor for loading a gamestate from a file using a
        // "Load Game" operation of some sort.
        #endregion

        #region Public Methods
        #endregion

        #region Private Methods
        #endregion
    }
}
