using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetherTear.Framework.GameObjects;
using NetherTear.Framework.Control;
using NetherTear.Framework.Config;
using NetherTear.Framework.Maps;

namespace NetherTear.Framework.Engine
{
    public class GameState
    {
        #region Public Variables
        public Player Player { get; set; }
        public ControllerBase Controller { get; set; }
        public GraphicsConfig GraphicsConfig { get; set; }
        public MapBase CurrentMap { get; set; }
        public List<CellBase> CurrentCells
        {
            get
            {
                var currCells = new List<CellBase>();
                int cellX = (int)(Player.X / CellBase.Width);
                int cellY = (int)(Player.Y / CellBase.Height);

                if (CurrentMap.ContainsCellIndex(cellY, cellX))
                    currCells.Add(CurrentMap.Cells[cellY, cellX]);

                if (CurrentMap.ContainsCellIndex(cellY - 1, cellX))
                    currCells.Add(CurrentMap.Cells[cellY - 1, cellX]);
                
                if (CurrentMap.ContainsCellIndex(cellY, cellX - 1))
                    currCells.Add(CurrentMap.Cells[cellY, cellX - 1]);
                
                if (CurrentMap.ContainsCellIndex(cellY + 1, cellX))
                    currCells.Add(CurrentMap.Cells[cellY + 1, cellX]);

                if (CurrentMap.ContainsCellIndex(cellY, cellX + 1))
                    currCells.Add(CurrentMap.Cells[cellY, cellX + 1]);

                if (CurrentMap.ContainsCellIndex(cellY + 1, cellX + 1))
                    currCells.Add(CurrentMap.Cells[cellY + 1, cellX + 1]);

                if (CurrentMap.ContainsCellIndex(cellY - 1, cellX - 1))
                    currCells.Add(CurrentMap.Cells[cellY - 1, cellX - 1]);

                if (CurrentMap.ContainsCellIndex(cellY - 1, cellX + 1))
                    currCells.Add(CurrentMap.Cells[cellY - 1, cellX + 1]);

                if (CurrentMap.ContainsCellIndex(cellY + 1, cellX - 1))
                    currCells.Add(CurrentMap.Cells[cellY + 1, cellX - 1]);

                return currCells;
            }
        }
        #endregion

        #region Constructors
        // this constructor should initialize a "New Game" gamestate
        public GameState()
        {
            this.Player = new Player(50, 50);
            this.Controller = new MainGameController(Player);
            this.GraphicsConfig = new GraphicsConfig();

            // temporary current map
            CurrentMap = new SampleForestMap();
        }

        // todo: need a constructor for loading a gamestate from a file using a
        // "Load Game" operation of some sort.
        #endregion

        #region Public Methods
        #endregion

        #region Private Methods
        #endregion
    }
}
