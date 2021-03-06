using System;
using System.Threading;
using System.Threading.Tasks;
using ConsoleEngine;
using ConsoleEngine.Objects;

namespace UIExample
{
    public class UIExample //: Game
    {
        /*
        private GraphicsDevice graphics;
        private InterfaceManager uinterface;
        private InputHandler input;

        private World world1;

        private int index;

        public Launcher(string[] args) : base(args) {}

        protected override void Load()
        {
            index = 1;

            graphics = new GraphicsDevice(100, 40, "CE Launcher 1.0");
            uinterface = new InterfaceManager();
            input = new InputHandler();

            world1 = new World(new Vector2(100, 40));

            new Outline("',", ConsoleColor.White, new Vector2(50, 20), new Vector2(90, 36), new Vector2(8, 4)).Add(world1);
            new Image(args[0] + "/launcher/resources/images/logo.txt", new Vector2(16, 7)).Add(world1);
            new Button("[Launch Stars]", ConsoleColor.White, ConsoleColor.DarkGray, new Vector2(16, 13), 1).Add(uinterface);
            new Button("[Useless Button]", ConsoleColor.White, ConsoleColor.DarkGray, new Vector2(16, 15), 2).Add(uinterface);
            new Button("[Quit]", ConsoleColor.White, ConsoleColor.DarkGray, new Vector2(16, 17), 3).Add(uinterface);
        }

        protected override void Unload()
        {
            graphics = null;
            uinterface = null;
            input = null;
        }

        protected override void Update()
        {
            Thread.Sleep(10);

            ConsoleKey key = input.GetKey();

            if (key == ConsoleKey.UpArrow)
                index--;

            if (key == ConsoleKey.DownArrow)
                index++;

            if (index == 0)
                index = uinterface.buttons.Count;

            if (index == uinterface.buttons.Count + 1)
                index = 1;

            uinterface.SelectButton(index);

            if (key == ConsoleKey.Enter)
            {
                if (index == 1)
                {
                    ChangeGame(new Stars(args));
                }

                if (index == 3)
                {
                    Stop();
                }
            }
        }

        protected override void Draw()
        {
            world1.Draw();

            uinterface.Draw(world1);

            graphics.Refresh(world1);
        }
        */
    }
}