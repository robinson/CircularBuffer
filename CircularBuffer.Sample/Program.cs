using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularBuffer.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularBuffer<data> buffer = new CircularBuffer<data>();
            //write to circular 6 elements
            buffer.Enqueue(new data { What = "0", When = DateTime.Now });
            
            buffer.Enqueue(new data { What = "1", When = DateTime.Now });
            
            buffer.Enqueue(new data { What = "2", When = DateTime.Now });
            
            buffer.Enqueue(new data { What = "3", When = DateTime.Now });
            
            buffer.Enqueue(new data { What = "4", When = DateTime.Now });
            
            buffer.Enqueue(new data { What = "5", When = DateTime.Now });


            //read from circular top 3 elements
            for (int i = 0; i < 4; ++i)
            {
                var tempData = buffer.Dequeue();
                Console.WriteLine(tempData.What + "---" + tempData.When);
            }
            //continue write to circular 4 elements
            buffer.Enqueue(new data { What = "6", When = DateTime.Now });

            buffer.Enqueue(new data { What = "7", When = DateTime.Now });

            buffer.Enqueue(new data { What = "8", When = DateTime.Now });

            buffer.Enqueue(new data { What = "9", When = DateTime.Now });

            //read from circular top 4 elements

            for (int i = 0; i < 5; ++i)
            {
                var tempData = buffer.Dequeue();
                Console.WriteLine( tempData.What + "---" + tempData.When);
            }
            Console.WriteLine("finally we have: " + buffer.Count + " element(s), what is this? press [ENTER]");
            Console.ReadLine();
            var finalData = buffer.Dequeue();
            Console.WriteLine(finalData.What + "---" + finalData.When);
            Console.ReadLine();
        }
    }
    public class data
    {
        public string What { get; set; }
        public DateTime When { get; set; }
    }
}
