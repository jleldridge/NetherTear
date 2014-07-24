using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetherTear.Framework.Util;

namespace NetherTear.Framework.View
{
    public class SpriteSheet
    {
        #region Public Variables
        public string SourceTexture { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Dictionary<string, Rectangle> TextureRegions { get; set; } 
        #endregion

        #region Constructors
        public SpriteSheet(string sourceImagePath, int sourceImageWidth,
            int sourceImageHeight)
        {
            this.SourceTexture = sourceImagePath;
            this.Width = sourceImageWidth;
            this.Height = sourceImageHeight;
            TextureRegions = new Dictionary<string, Rectangle>();
        }
        #endregion

        #region Public Methods
        public void DefineRegion(string regionName, float x, float y, 
            float width, float height)
        {
            TextureRegions.Add(regionName, new Rectangle(x, y, width, height));
        }

        public void RemoveRegion(string regionName)
        {
            TextureRegions.Remove(regionName);
        }
        #endregion
    }
}
