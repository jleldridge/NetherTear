using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using NetherTear.Framework.Engine;
using NetherTear.Framework.GameObjects;
using NetherTear.Framework.Config;

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
            DrawPlayer();
            SpriteBatch.End();
        }
        #endregion

        #region Private Methods
        private void DrawPlayer()
        {
            Player player = GameState.Player;
            SpriteBatch.Draw(Textures["PlayerImage"], GetObjectPos(player), 
                Color.White);
        }

        private Vector2 GetObjectPos(GameObjectBase obj)
        {
            return new Vector2(obj.X, obj.Y);
        }
        #endregion
    }
}
