using System;
using System.Drawing;


namespace Game_Asteroids
{
    /// <summary>
    /// Класс для объектов и прорисовки движения
    /// </summary>
    class BaseObject
    {
        protected Point pos;
        protected Point dir;
        protected Size size;
        Image asteridImg = Image.FromFile(@"img\asteroid.png");
        static Image background = Image.FromFile(@"img\Background.jpg");
        Random random = new Random();

        bool flag = true;

        public BaseObject()
        {
        }

        public BaseObject(Point pos, Point dir)
        {
            this.pos = pos;
            this.dir = dir;
        }

        public BaseObject(Point pos, Point dir, Size size)
        {
            this.pos = pos;
            this.dir = dir;
            this.size = size;
        }

        public virtual void Draw()
        {
            Game.Buffer.Graphics.DrawImage(asteridImg, pos.X, pos.Y, size.Width, size.Height);
        }

        public virtual void Update()
        {
            if (flag)
            {
                pos.X += dir.X / 10;
                pos.Y -= dir.Y / 10;
                if (pos.X < 0)
                {
                    pos.X = Game.Width;
                    pos.X -= 5;
                    dir.Y = -dir.Y;
                    flag = false;
                    pos.Y -= 10;
                }
                if (pos.Y < 0 || pos.Y > Game.Height - 20)
                {
                    pos.X = random.Next(10, 560);
                    dir.Y = -dir.Y;
                }
            }
            else
            {
                pos.X += dir.X / 10;
                if (pos.X < 0)
                {
                    pos.X = Game.Width;
                    pos.X -= 5;
                    dir.Y = -dir.Y;
                    flag = true;
                }
            }
        }

        static public void ClearScreen()
        {
            Game.Buffer.Graphics.DrawImage(background, 0, 0);
        }
    }
}
