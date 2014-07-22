using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetherTear.Framework.Engine;

namespace NetherTear.Framework.View
{
    class MapCamera
    {
        #region Private Variables
        private GameState gameState;
        #endregion

        #region Constructors
        public MapCamera(GameState gameState)
        {
            this.gameState = gameState;
        }
        #endregion

        #region Public Methods
        public void GetCameraBounds(out float leftX, out float rightX, out float topY, out float bottomY)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
