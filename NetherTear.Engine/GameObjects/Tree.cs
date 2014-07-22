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
        public override string ImagePath
        {
            get { return ObjectImages.TreeImagePath; }
        }
        #endregion

        #region Public Variables
        #endregion

        #region Constructors
        public Tree(float x, float y) : base(x, y, 40, 40) 
        {
        }
        #endregion

        #region Public Methods
        #endregion

        #region Private Methods
        #endregion
    }
}
