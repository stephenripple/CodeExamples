using System;
using System.Threading.Tasks;

namespace CodeExamples
{
    //Tuples help when using anonymous methods and object instantiation on complex objects while keeping strong typing. 
    //Basically scenarios where you are using a lot of custom types or structs to pass around but never directly provides any value in the application.
    public class Tuples
    {
        //Example instantiation
        Tuple<int, int, string> example = new Tuple<int, int, string>(1, 1, "Test");

        public static int TupleExample()
        {
            Nullable<int> ret = null;
            Task.Factory.StartNew(() =>
            {
                return Tuple.Create(CreateTuple());
            }).ContinueWith(record =>
            {
                if (!record.IsFaulted)
                {
                    ret = record.Result.Item1.Item1;
                }
            }).Wait();
            return (ret.HasValue ? ret.Value : 0);
        }

        private static Tuple<int, string, string, DateTime> CreateTuple()
        {
            Tuple<int, string, string, DateTime> ret = new Tuple<int, string, string, DateTime>(1, "Color", "Blue", DateTime.UtcNow);
            return ret;
        }
    }
}
