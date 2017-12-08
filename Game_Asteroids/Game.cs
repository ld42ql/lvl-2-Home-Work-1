﻿using System;
using System.Windows.Forms;
using System.Drawing;

namespace Game_Asteroids
{
   static class Game
    {
        private static BufferedGraphicsContext context;
        public static BufferedGraphics Buffer;
       static Random random = new Random();
        /// <summary>
        /// Ширина
        /// </summary>
        public static int Width { get; set; }
        /// <summary>
        /// Высота
        /// </summary>
        public static int Height { get; set; }

        static Game()
        {

        }
        
        public static BaseObject[] arrayObject;
       

        public static void LoadObject()
        {
            arrayObject = new BaseObject[250];

            for (int i = 0; i < 69; i++)
                arrayObject[i] = new Star(new Point(random.Next(0, 800), (i - 30) * random.Next(2, 30)), new Point(-i, 0), new Size(5, 5));

            arrayObject[69] = new FonObject(new Point(600, 50), new Point(1, 0));

            arrayObject[70] = new ShipObject();

            for (int i = 71; i < arrayObject.Length; i++)
            {
                int a = random.Next(15, 30);
                arrayObject[i] = new BaseObject(new Point(random.Next(0, 800), i * random.Next(2, 20)), new Point(10 - i, 10 - i),
                    new Size(i % 2 == 0 ? a : 10, i % 2 == 0 ? a : 10));
            }
            
        }

        /// <summary>
        /// Создаем поверхность рисования и связываем его с формой
        /// </summary>
        /// <param name="form"></param>
        public static void Init(Form form)
        {
            Graphics graphics;

            context = BufferedGraphicsManager.Current;

            graphics = form.CreateGraphics();

            Width = form.Width;
            Height = form.Height;

            Buffer = context.Allocate(graphics, new Rectangle(0, 0, Width, Height));

            Timer timer = new Timer { Interval = 100 };
            timer.Start();

            LoadObject();
            timer.Tick += Timer_Tick;
        }

       

        public static void Draw()
        {
            Buffer.Graphics.Clear(Color.Black);
            BaseObject.ClearScreen();

            foreach (BaseObject item in arrayObject)
                item.Draw();

            Buffer.Render();
        }

        public static void Update()
        {
            foreach (BaseObject item in arrayObject)
            {
                item.Update();
            }
        }

        private static void Timer_Tick(object sender, EventArgs e)
        {
            Update();
            Draw();
        }
    }
}