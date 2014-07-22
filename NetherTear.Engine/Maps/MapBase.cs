using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetherTear.Framework.GameObjects;

namespace NetherTear.Framework.Maps
{
    public abstract class MapBase
    {
        #region Public Variables
        public int WidthInCells { get; set; }
        public int HeightInCells { get; set; }
        public CellBase [,] Cells { get; set; }
        public CellBase CurrentCell { get; set; }
        #endregion

        #region Constructors
        public MapBase(int widthInCells, int heightInCells)
        {
            this.WidthInCells = widthInCells;
            this.HeightInCells = heightInCells;
            this.Cells = new CellBase[WidthInCells, HeightInCells];
        }
        #endregion

        #region Public Methods
        public void AddObject(GameObjectBase obj)
        {
            int cellX = (int)(obj.X / CellBase.Width);
            int cellY = (int)(obj.Y / CellBase.Height);
            if (cellX < WidthInCells && cellY < HeightInCells)
            {
                var cell = Cells[cellX, cellY];
                cell.Objects.Add(obj);
            }
        }

        public void AddObject(GameObjectBase obj, float x, float y)
        {
            obj.X = x;
            obj.Y = y;
            int cellX = (int)(obj.X / CellBase.Width);
            int cellY = (int)(obj.Y / CellBase.Height);
            if (cellX < WidthInCells && cellY < HeightInCells)
            {
                var cell = Cells[cellX, cellY];
                cell.Objects.Add(obj);
            }
        }
        #endregion
    }
}
