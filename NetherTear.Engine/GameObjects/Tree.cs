using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetherTear.Resources;

namespace NetherTear.Framework.GameObjects
{
    class Tree : GameObjectBase
    {
        #region Private Variables
        #endregion

        #region Public Variables
        public override string Texture
        {
            get { return "Tree"; }
        }
        #endregion

        #region Constructors
        public Tree(float x, float y) : base(x, y, 80, 80) 
        {
        }
        #endregion

        #region Public Methods
        #endregion

        #region Private Methods
        #endregion
    }
}
