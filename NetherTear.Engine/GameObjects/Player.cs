using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetherTear.Resources;

namespace NetherTear.Framework.GameObjects
{
    public class Player : GameObjectBase
    {
        public override string ImagePath
        {
            get { return ObjectImages.PlayerImagePath; }
        }

        public Player(float x, float y) : base(x, y, 40, 40)
        {
            this.MaxXSpeed = 5;
            this.MaxYSpeed = 5;
        }
    }
}
