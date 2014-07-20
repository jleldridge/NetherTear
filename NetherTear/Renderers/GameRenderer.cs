using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using NetherTear.Framework.Engine;
using NetherTear.Framework.GameObjects;

namespace NetherTear.MonoGame.Renderers
{
    public class GameRenderer
    {
        #region Private Variables
        #endregion

        #region Public Variables
        public GameState GameState { get; set; }
        public GraphicsDeviceManager Graphics { get; set; }
        public SpriteBatch SpriteBatch { get; set; }
        public Dictionary<string, Texture2D> Textures { get; set; }
        #endregion

        #region Constructors
        public GameRenderer()
        {
        }
        #endregion

        #region Public Methods
        public void Draw()
        {
            SpriteBatch.Begin();
            DrawPlayer();
            SpriteBatch.End();
        }
        #endregion

        #region Private Methods
        private void DrawPlayer()
        {
            Player player = GameState.Player;
            SpriteBatch.Draw(Textures["PlayerImage"],
                new Rectangle(player.X, player.Y, 25, 25), Color.White);
        }
        #endregion
    }
}
