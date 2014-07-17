using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetherTear.Framework.GameObjects
{
    public abstract class GameObjectBase
    {
        #region Properties
        public int X { get; set; }
        public int Y { get; set; }
        public int XSpeed { get; set; }
        public int YSpeed { get; set; }
        public abstract string ImagePath { get; }
        #endregion

        public GameObjectBase(int x, int y)
        {
            X = x;
            Y = y;
            XSpeed = 0;
            YSpeed = 0;
        }
    }
}
