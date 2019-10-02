//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;

//namespace Test
//{
//    class Program
//    {
//        void Testing()
//        {
//            var a = new List<int>()
//            {
//                1,2,3,4,5,
//            };

//            var e = a.Select((x) => {
//                return x + 1;
//            });

//            IEnumerable<int> b = a;

//            var ct = 0;
//            foreach(var c in e)
//            {
//                Console.WriteLine(c);

//                if (++ct > 2) break;
//            }

//            Console.WriteLine("-----");

//            foreach (var d in e)
//            {
//                Console.WriteLine(d);
//            }
//        }
//    }
//}
