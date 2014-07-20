using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetherTear.Framework.Config
{
    public class MainGameControllerConfig : ControllerConfigBase
    {
        #region Public Variables
        public MainGameControllerConfig Config { get; set; }
        #endregion

        #region Constructors
        public MainGameControllerConfig()
        {

        }
        #endregion

        public override void RestoreDefaults()
        {
             throw new NotImplementedException();
        }
    }
}
