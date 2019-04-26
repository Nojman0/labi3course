using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class MyEvent

    {



        [DllImport("user32.dll", SetLastError = true)]



        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);



        public void pressLeftMouse()

        {

            mouse_event((uint)MouseEventFlags.LEFTDOWN, 0, 0, 0, 0);

            mouse_event((uint)MouseEventFlags.LEFTUP, 0, 0, 0, 0);

        }

    }



    [Flags]

    public enum MouseEventFlags

    {

        LEFTDOWN = 0x00000002,

        LEFTUP = 0x00000004,

        MIDDLEDOWN = 0x00000020,

        MIDDLEUP = 0x00000040,

        MOVE = 0x00000001,

        ABSOLUTE = 0x00008000,

        RIGHTDOWN = 0x00000008,

        RIGHTUP = 0x00000010

    }


    class Program

    {
        static void Main(string[] args)

        {

            MyEvent Event = new MyEvent();

             ConsoleKeyInfo input;

        x:

            input = Console.ReadKey(true);

        

            if (input.Key == ConsoleKey.W)

            {

                Event.pressLeftMouse();
                
                goto x;

            }

            Console.Read();

        }
    }
}

