using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetherTear.Framework.GameObjects;

namespace NetherTear.Framework.Maps
{
    class SampleForestMap : MapBase
    {
        public SampleForestMap() : base(20, 20)
        {
            for (int i = 0; i < WidthInCells; i++)
            {
                for (int j = 0; j < HeightInCells; j++)
                {
                    Cells[j, i] = new OutdoorCell(i, j);
                    AddObject(new Tree(i * CellBase.Width + 50, j * CellBase.Height + 50));
                }
            }
        }
    }
}
