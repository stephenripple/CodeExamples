using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExamples
{
    public class Tuples
    {
        //Example instantiation
        Tuple<int, int, string> example = new Tuple<int, int, string>(1, 1, "Test");

        public static int FactoryExample()
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
