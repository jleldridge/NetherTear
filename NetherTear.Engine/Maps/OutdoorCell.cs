using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetherTear.Framework.Maps
{
    public class OutdoorCell : CellBase
    {
        #region Public Variables
        public override float StartX
        {
            get { throw new NotImplementedException();  }
        }
        public override float StartY
        {
            get { throw new NotImplementedException(); }
        }
        public override float EndX
        {
            get { throw new NotImplementedException(); }
        }
        public override float EndY
        {
            get { throw new NotImplementedException(); }
        }
        #endregion

        #region Constructors
        public OutdoorCell(int xPos, int yPos) : base(xPos, yPos)
        {
        }
        #endregion
    }
}
