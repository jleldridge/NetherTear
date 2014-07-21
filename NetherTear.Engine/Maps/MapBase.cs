using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetherTear.Framework.Maps
{
    public abstract class MapBase<T> where T : CellBase
    {
        #region Public Variables
        public int WidthInCells { get; set; }
        public int HeightInCells { get; set; }
        public T [][] Cells { get; set; }
        public T CurrentCell { get; set; }
        #endregion

        #region Constructors
        #endregion

        #region Public Methods
        #endregion
    }
}
