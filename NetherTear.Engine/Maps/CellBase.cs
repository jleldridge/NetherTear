using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetherTear.Framework.GameObjects;
using NetherTear.Framework.View;

namespace NetherTear.Framework.Maps
{
    public abstract class CellBase
    {
        #region Private Variables
        #endregion

        #region Public Variables
        public static float Width = 1600;
        public static float Height = 900;
        public Sprite[,] Tiles { get; set; }
        /// <summary>
        /// The x coordinate in the parent map's cell array
        /// </summary>
        public int XPos { get; set; }
        /// <summary>
        /// The y coordinate in the parent map's cell array
        /// </summary>
        public int YPos { get; set; }
        /// <summary>
        /// The x coordinate on the map where this cell begins
        /// </summary>
        public float MapXStart
        {
            get { return XPos * Width; }
        }
        /// <summary>
        /// The y coordinate on the map where this cell begins
        /// </summary>
        public float MapYStart
        {
            get { return YPos * Height; }
        }

        public List<GameObjectBase> Objects { get; set; }
        #endregion

        #region Constructors
        public CellBase(int xPos, int yPos, Sprite[,] tiles)
        {
            this.XPos = xPos;
            this.YPos = yPos;
            this.Tiles = tiles;
            Objects = new List<GameObjectBase>();
        }
        #endregion
    }
}
