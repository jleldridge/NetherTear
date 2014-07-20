using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetherTear.Framework.Config
{
    public class GraphicsConfig
    {
        #region Private Variables
        #endregion

        #region Public Variables
        public static readonly int DefaultWidth = 1600;
        public static readonly int DefaultHeight = 900;

        public int Width { get; set; }
        public int Height { get; set; }
        #endregion

        #region Constructors
        public GraphicsConfig()
        {
            RestoreDefaults();
        }
        #endregion

        #region Public Methods
        public void RestoreDefaults()
        {
            Width = DefaultWidth;
            Height = DefaultHeight;
        }
        #endregion
    }
}
