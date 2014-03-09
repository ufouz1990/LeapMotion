using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Leap;
using System.Threading;

namespace LeapMotionConsole
{
    public class CustomListener : Listener
    {
        public event Action<FingerList> OnFingersRegistered;
        public event Action<GestureList> OnGesturesMade;

        private long _now;
        private long _previous;
        private long _timeDifference;

        public override void OnConnect(Controller controller)
        {
            Console.WriteLine("Leap Motion connected to service");
        }

        public override void OnFrame(Controller controller)
        {
            using (var frame = controller.Frame())
            {
                Vector A = new Vector(2, 0, 0);
                Vector B = new Vector(4, 2, 0);
                double rads = Math.Round(A.AngleTo(B), 2);
                Console.WriteLine("Radians " + rads);
                //Console.WriteLine("Degrees " + Math.Round(rads*180/Math.PI, 2));

                //Console.WriteLine("Thumb: " + Math.Round(frame.Fingers[0].Length / 10, 2) + "cm");
                //Console.WriteLine("Index: " + Math.Round(frame.Fingers[1].Length / 10, 2) + "cm");
                //Console.WriteLine("Middle: " + Math.Round(frame.Fingers[2].Length / 10, 2) + "cm");
                //Console.WriteLine("Ring: " + Math.Round(frame.Fingers[3].Length / 10, 2) + "cm");
                //Console.WriteLine("Pinky: " + Math.Round(frame.Fingers[4].Length / 10, 2) + "cm\n");
            }
            Console.ReadLine();

            //Thread.Sleep(2000);

            //using (var frame = controller.Frame())
            //{
            //    _now = frame.Timestamp;
            //    _timeDifference = _now - _previous;

            //    if (frame.Hands.IsEmpty || _timeDifference < 5000)
            //    {
            //        return;
            //    }

            //    _previous = frame.Timestamp;

            //    if (frame.Gestures().Count > 0 && OnGesturesMade != null)
            //    {
            //        OnGesturesMade(frame.Gestures());
            //    }

            //    if (frame.Fingers.Count > 0 && OnFingersRegistered != null)
            //    {
            //        OnFingersRegistered(frame.Fingers);
            //    }
            //}
        }
    }
}
