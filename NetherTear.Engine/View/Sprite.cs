using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetherTear.Resources;
using NetherTear.Framework.Util;

namespace NetherTear.Framework.View
{
    public class Sprite
    {
        #region Public Variables
        public SpriteSheet SpriteSheet { get; set; }
        public string CurrentTexture { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        #endregion

        #region Constructors
        public Sprite(SpriteSheet spriteSheet, float width, float height)
        {
            this.SpriteSheet = spriteSheet;
            this.Width = width;
            this.Height = height;
        }
        #endregion

        #region Public Methods
        public Rectangle GetCurrentTextureBounds()
        {
            return SpriteSheet.TextureRegions[CurrentTexture];
        }
        #endregion
    }
}
