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
        public int MaxXSpeed { get; set; }
        public int MaxYSpeed { get; set; }
        public abstract string ImagePath { get; }
        #endregion

        public GameObjectBase(int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.XSpeed = 0;
            this.YSpeed = 0;
        }
    }
}
