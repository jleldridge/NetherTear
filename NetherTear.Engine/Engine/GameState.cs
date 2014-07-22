using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetherTear.Framework.GameObjects;
using NetherTear.Framework.Control;
using NetherTear.Framework.Config;
using NetherTear.Framework.Maps;

namespace NetherTear.Framework.Engine
{
    public class GameState
    {
        #region Public Variables
        public Player Player { get; set; }
        public ControllerBase Controller { get; set; }
        public GraphicsConfig GraphicsConfig { get; set; }
        public MapBase CurrentMap { get; set; }
        #endregion

        #region Constructors
        // this constructor should initialize a "New Game" gamestate
        public GameState()
        {
            this.Player = new Player(50, 50);
            this.Controller = new MainGameController(Player);
            this.GraphicsConfig = new GraphicsConfig();
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
