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
                    AddObject(new Tree(i * CellBase.Width + 100, j * CellBase.Height + 50));
                    AddObject(new Tree(i * CellBase.Width + 150, j * CellBase.Height + 50));
                    AddObject(new Tree(i * CellBase.Width + 200, j * CellBase.Height + 50));
                    AddObject(new Tree(i * CellBase.Width + 250, j * CellBase.Height + 50));
                    AddObject(new Tree(i * CellBase.Width + 300, j * CellBase.Height + 50));
                    AddObject(new Tree(i * CellBase.Width + 350, j * CellBase.Height + 50));
                    AddObject(new Tree(i * CellBase.Width + 400, j * CellBase.Height + 50));
                    AddObject(new Tree(i * CellBase.Width + 450, j * CellBase.Height + 50));
                    AddObject(new Tree(i * CellBase.Width + 500, j * CellBase.Height + 50));
                    AddObject(new Tree(i * CellBase.Width + 550, j * CellBase.Height + 50));
                    AddObject(new Tree(i * CellBase.Width + 600, j * CellBase.Height + 50));
                    AddObject(new Tree(i * CellBase.Width + 650, j * CellBase.Height + 50));
                    AddObject(new Tree(i * CellBase.Width + 700, j * CellBase.Height + 50));
                    AddObject(new Tree(i * CellBase.Width + 750, j * CellBase.Height + 50));
                }
            }
        }
    }
}
