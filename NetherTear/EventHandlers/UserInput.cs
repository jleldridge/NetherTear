using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
using NetherTear.Framework.Control;

namespace NetherTear.EventHandlers
{
    public class UserInput
    {
        #region Private Variables
        #endregion

        #region Public Variables
        public ControllerBase Controller;
        #endregion

        public UserInput(ControllerBase controller)
        {
            this.Controller = controller;
        }
    }
}
