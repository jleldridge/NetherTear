using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetherTear.Framework.GameObjects
{
    public abstract class GameObjectBase
    {
        #region Properties
        public float X { get; set; }
        public float Y { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public float XSpeed { get; set; }
        public float YSpeed { get; set; }
        public float MaxXSpeed { get; set; }
        public float MaxYSpeed { get; set; }
        public abstract string Texture { get; }
        #endregion

        public GameObjectBase(float x, float y, float width, float height)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
            this.XSpeed = 0;
            this.YSpeed = 0;
        }
    }
}
