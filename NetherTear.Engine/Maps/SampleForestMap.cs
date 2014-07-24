using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetherTear.Framework.GameObjects;
using NetherTear.Framework.View;
using NetherTear.Resources;

namespace NetherTear.Framework.Maps
{
    class SampleForestMap : MapBase
    {
        public SpriteSheet GrassTile1 = new SpriteSheet("GrassTile1", 25, 25);
        public SampleForestMap() : base(20, 20)
        {
            GrassTile1.DefineRegion("Grass", 0, 0, 25, 25);

            for (int i = 0; i < WidthInCells; i++)
            {
                for (int j = 0; j < HeightInCells; j++)
                {
                    var sprites = PopulateCellSpritesWithGrass();

                    Cells[j, i] = new OutdoorCell(i, j, sprites);
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

        private Sprite[,] PopulateCellSpritesWithGrass()
        {
            var sprites = new Sprite[900 / 25, 1600 / 25];
            for (int i = 0; i <= sprites.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= sprites.GetUpperBound(1); j++)
                {
                    var sprite = new Sprite(GrassTile1, 25, 25);
                    sprite.CurrentTexture = "Grass";
                    sprites[i, j] = sprite;
                }
            }

            return sprites;
        }
    }
}
