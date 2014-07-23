using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetherTear.Framework.Maps
{
    public class OutdoorCell : CellBase
    {
        #region Public Variables
        #endregion

        #region Constructors
        public OutdoorCell(int xPos, int yPos) : base(xPos, yPos)
        {
            this.BackgroundTexture = "Grass";
        }
        #endregion
    }
}
