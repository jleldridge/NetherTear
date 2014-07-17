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
        public Player Player { get; set; }
        #endregion

        #region Constructors
        public Engine ()
        {
            Player = new Player(50, 50);
            Player.XSpeed = 5;
            Player.YSpeed = 5;
        }
        #endregion

        #region Public Methods
        public void Update()
        {
            MovePlayer();
        }
        #endregion

        #region Private Methods
        private void MovePlayer()
        {
            Player.X += Player.XSpeed;
            Player.Y += Player.YSpeed;
        }
        #endregion
    }
}
