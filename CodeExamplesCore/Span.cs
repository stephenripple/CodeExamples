using System;
using Microsoft.AspNetCore.Server.Kestrel.Internal.System;

namespace CodeExamplesCore
{
    public class Span
    {
        private string _teststring;
        public string TestString
        {
            get
            {
                return _teststring;
            }
        }


        public Span(string testString)
        {
            _teststring = testString;
        }

        //Processing with a Span gives us a lighter memory track than duplicating objects to process
        //If you have heavy string processing that can be expensive, span gives you a representation of contiguous regions of arbitrary memory in a safe way
        public Span<char> ProcessSubString(int start, int length)
        {
            Span<char> test = _teststring.ToCharArray();
            return test.Slice(start, length);
        }
    }
}
