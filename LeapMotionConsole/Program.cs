using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Leap;

namespace LeapMotionConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomListener listener = new CustomListener();
            Controller controller = new Controller();
            controller.AddListener(listener);

            Console.ReadKey();
            controller.Dispose();
        }
    }
}
