using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyFirstApp
{
    class Test2
    {
        public static void Main()
        {
            #region list
            //Console.WriteLine(DateTime.Today);
            ////Console.ReadLine();
            //List<string> arraylist = new List<string>();
            //arraylist.Add("ajay");
            //arraylist.Add("lax");
            //arraylist.Add("kunal");

            ////foreach( object o in arraylist)
            ////{
            ////    Console.WriteLine($"{o} : {o.GetType()}");
            ////}

            //foreach (object o in arraylist)
            //{
            //    Console.WriteLine(o);
            //}

            //Console.WriteLine("----------------");
            //arraylist.Remove("kunal");

            //arraylist.RemoveAt(1);

            //arraylist.Insert(1,"raj");

            //foreach (object o in arraylist)
            //{
            //    Console.WriteLine(o);
            //}
            #endregion
            #region sortedset
            //-----------------------------------------
            //SortedSet<string> arraylist = new SortedSet<string>();
            //arraylist.Add("ajay");
            //arraylist.Add("lax");
            //arraylist.Add("kunal");

            //foreach (object o in arraylist)
            //{
            //    Console.WriteLine(o);
            //}

            //Console.WriteLine("----------------");
            //arraylist.Remove("kunal");

            //foreach (object o in arraylist)
            //{
            //    Console.WriteLine(o);
            //}
            //------------------------------------------
            #endregion
            #region dictionary
            //Dictionary<string, List<string>> stateandcap = new Dictionary<string, List<string>>();
            var stateandcity = new Dictionary<string, List<string>>();

            stateandcity.Add("Karnataka", new List<string> {"Bangalore","Mysore"});
            stateandcity.Add("Maharastra", new List<string> { "Mumbai", "Pune" });
            stateandcity.Add("UK", new List<string> { "Doon", "Rishikesh","Srinager" });

            //string state= Console.ReadLine();

            //List<string> clist = stateandcity[state];

            //foreach (object city in clist)
            //{
            //    Console.WriteLine(city);
            //}


            foreach (string key in stateandcity.Keys)
            {
                Console.WriteLine($"State:-\t{key}");
                List<string> citylist = stateandcity[key];

                Console.WriteLine("Cities..");
                foreach (string c in citylist)
                {
                    Console.Write("\t");
                    Console.Write(c);
                }
                
            }
            #endregion
            #region s_q
            Stack<string> st = new Stack<string>();
            Queue<string> que = new Queue<string>();
            que.Enqueue("Bangalore");
            que.Enqueue("Delhi");
            que.Enqueue("Pune");
            que.Enqueue("Mysore");

            foreach( string city in que)
            {
                Console.WriteLine(city);
            }
            Console.WriteLine("-----------------");

            que.Dequeue();
            que.Dequeue();

            foreach (string city in que)
            {
                Console.WriteLine(city);
            }
            #endregion
            Console.ReadLine();
        }
    }
}
