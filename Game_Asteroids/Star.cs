using System;
using System.Drawing;
using System.Threading;


namespace Game_Asteroids
{
    class Star : BaseObject
    {
        Random random = new Random();

        Image astraImg = Image.FromFile(@"img\astra.png");
        public Star(Point pos, Point dir, Size size) : base(pos, dir, size)
        {

        }

        public override void Draw()
        {
            Game.Buffer.Graphics.DrawImage(astraImg, pos.X, pos.Y, 10, 10);
        }

        public override void Update()
        {
            pos.X += dir.X / 20;
            if (pos.X < 0)
            {
                pos.X = Game.Width;
              
            }
          
        }
    }
}
