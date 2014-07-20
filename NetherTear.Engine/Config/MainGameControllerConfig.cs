using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetherTear.Framework.Config
{
    public class MainGameControllerConfig : ControllerConfigBase<PlayerAction>
    {
        #region Public Variables
        public readonly Dictionary<UserInput, PlayerAction> ConfigDefault =
            new Dictionary<UserInput,PlayerAction>
        {
            {UserInput.W, PlayerAction.Up},
            {UserInput.S, PlayerAction.Down},
            {UserInput.A, PlayerAction.Left},
            {UserInput.D, PlayerAction.Right}
        };

        public Dictionary<UserInput, PlayerAction> Config;
        #endregion

        #region Constructors
        // new game constructor
        public MainGameControllerConfig()
        {
            // initialize Config to default settings
            RestoreDefaults();
        }

        // todo: there should be a "Load Game" constructor that the GameState class
        // can call to load a configuration from a saved game
        #endregion

        #region Public Methods
        public override PlayerAction this[UserInput key]
        {
            get
            {
                return Config[key];
            }
            set
            {
                Config[key] = value;
            }
        }
        
        public override void RestoreDefaults()
        {
            Config = new Dictionary<UserInput, PlayerAction>();
            foreach (var kvp in ConfigDefault)
            {
                Config.Add(kvp.Key, kvp.Value);
            }
        }
        #endregion
    }
}
