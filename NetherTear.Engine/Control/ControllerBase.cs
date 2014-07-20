using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetherTear.Framework.Config;

namespace NetherTear.Framework.Control
{
    public abstract class ControllerBase
    {
        public abstract void HandleUserInput(List<UserInput> inputsUp, List<UserInput> inputsDown);
        public abstract List<UserInput> GetMappedUserInput();
    }
}
