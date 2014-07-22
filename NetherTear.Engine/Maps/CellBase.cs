using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetherTear.Framework.GameObjects;

namespace NetherTear.Framework.Maps
{
    public abstract class CellBase
    {
        #region Private Variables
        #endregion

        #region Public Variables
        public static float Width = 16000;
        public static float Height = 9000;
        /// <summary>
        /// The x coordinate in the parent map's cell array
        /// </summary>
        public int XPos { get; set; }
        /// <summary>
        /// The y coordinate in the parent map's cell array
        /// </summary>
        public int YPos { get; set; }
        public List<GameObjectBase> Objects { get; set; }
        public abstract float StartX { get; }
        public abstract float StartY { get; }
        public abstract float EndX { get; }
        public abstract float EndY { get; }
        #endregion

        #region Constructors
        public CellBase(int xPos, int yPos)
        {
            this.XPos = xPos;
            this.YPos = yPos;
        }
        #endregion
    }
}
