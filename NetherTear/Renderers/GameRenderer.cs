using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using NetherTear.Framework.Engine;
using NetherTear.Framework.GameObjects;
using NetherTear.Framework.Config;
using NetherTear.Framework.Maps;

namespace NetherTear.MonoGame.Renderers
{
    public class GameRenderer
    {
        #region Private Variables
        private Matrix scale;
        #endregion

        #region Public Variables
        public GameState GameState { get; set; }
        public GraphicsDeviceManager Graphics { get; set; }
        public SpriteBatch SpriteBatch { get; set; }
        public Dictionary<string, Texture2D> Textures { get; set; }
        public Dictionary<string, SpriteFont> SpriteFonts { get; set; }
        public float CenterX { get { return GraphicsConfig.DefaultWidth / 2.0f; } }
        public float CenterY { get { return GraphicsConfig.DefaultHeight / 2.0f; } }
        #endregion

        #region Constructors
        public GameRenderer(GraphicsDeviceManager graphics)
        {
            this.Graphics = graphics;
        }
        #endregion

        #region Public Methods
        public void Initialize()
        {
            var config = GameState.GraphicsConfig;

            // temporary hard coded screen resolution
            config.Width = 1280;
            config.Height = 720;

            Graphics.PreferredBackBufferWidth = config.Width;
            Graphics.PreferredBackBufferHeight = config.Height;
            Graphics.ApplyChanges();
            
            // calculate the scale based on the default screen size and actual
            // screen size
            float xScale = 
                (float)config.Width / (float)GraphicsConfig.DefaultWidth;
            float yScale = 
                (float)config.Height / (float)GraphicsConfig.DefaultHeight;

            scale = Matrix.CreateScale(xScale, yScale, 1f);
        }
        
        public void Draw()
        {
            SpriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend,
                null, null, null, null, scale);
            
            // the ordering here is important to determine what gets drawn in
            // front of what
            DrawCellBackgrounds();

            // temp debug
            DrawPlayerPosition();
            
            DrawPlayer();
            DrawGameObjects();
            SpriteBatch.End();
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Draws the player's current x and y position at the top left
        /// of the screen for debugging purposes.
        /// </summary>
        private void DrawPlayerPosition()
        {
            var playerPositionString = string.Format("Player X: {0}\nPlayer Y: {1}",
                GameState.Player.X, GameState.Player.Y);
            SpriteBatch.DrawString(SpriteFonts["Default"], playerPositionString,
                new Vector2(5, 5), Color.White);
        }

        private void DrawCellBackgrounds()
        {
            foreach (var cell in GameState.CurrentCells)
            {
                DrawCellBackground(cell);
            }
        }

        private void DrawCellBackground(CellBase cell)
        {
            var cellStartVector = new Vector2(cell.MapXStart, cell.MapYStart);
            var drawVector = cellStartVector - GetCameraTopLeft();

            SpriteBatch.Draw(Textures[cell.BackgroundTexture], drawVector, Color.White);
        }

        private void DrawPlayer()
        {
            Player player = GameState.Player;
            float playerDrawX = CenterX - (player.Width / 2);
            float playerDrawY = CenterY - (player.Height / 2);
            
            SpriteBatch.Draw(Textures[player.Texture], 
                new Vector2(playerDrawX, playerDrawY), 
                Color.White);
        }

        private void DrawGameObjects()
        {
            var objects = new List<GameObjectBase>();

            foreach (var cell in GameState.CurrentCells)
            {
                objects.AddRange(cell.Objects);
            }

            foreach (var obj in objects)
            {
                DrawGameObject(obj);
            }
        }

        private void DrawGameObject(GameObjectBase obj)
        {
            var drawVector = GetObjectPos(obj) - GetCameraTopLeft();
            
            SpriteBatch.Draw(Textures[obj.Texture], drawVector, 
                Color.White);
        }

        private Vector2 GetCameraTopLeft()
        {
            var player = GameState.Player;
            float x = (player.X + (player.Width / 2.0f)) -
                (GraphicsConfig.DefaultWidth / 2.0f);
            float y = (player.Y + (player.Width / 2.0f)) -
                (GraphicsConfig.DefaultHeight / 2.0f);

            return new Vector2(x, y);
        }

        private Vector2 GetObjectPos(GameObjectBase obj)
        {
            return new Vector2(obj.X, obj.Y);
        }
        #endregion
    }
}
