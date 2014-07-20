using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetherTear.Framework.GameObjects;

namespace NetherTear.Framework.Engine
{
    public class Engine
    {
        #region Private Variables
        #endregion

        #region Public Variables
        public GameState GameState { get; set; }
        #endregion

        #region Constructors
        public Engine ()
        {
            GameState = new GameState();
        }

        // this constructor could be used to load a saved game
        // or possibly to restore a game after pausing if the
        // engine needs to be scrapped during that process
        public Engine(GameState gameState)
        {
            this.GameState = gameState;
        }
        #endregion

        #region Public Methods
        public void Update()
        {
            MoveObject(GameState.Player);
        }
        #endregion

        #region Private Methods
        private void MoveObject(GameObjectBase obj)
        {
            obj.X += obj.XSpeed;
            obj.Y += obj.YSpeed;
        }
        #endregion
    }
}
