using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Asteroids
{
    class ShipObject : BaseObject
    {

        public ShipObject()
        {
        }

        public override void Draw()
        {
            Game.Buffer.Graphics.DrawImage(Resources.starShip, 100, 450, 20, 37);
        }
    }
}
