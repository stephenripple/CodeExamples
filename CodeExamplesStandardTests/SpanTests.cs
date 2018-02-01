using System;
using Xunit;
using CodeExamplesCore;
using Microsoft.AspNetCore.Server.Kestrel.Internal.System;

namespace CodeExamplesStandardTests
{
    public class SpanTests
    {
        [Fact]
        public void ProcessSubStringTest()
        {
            Span test = new Span("Test String");
            var tmp = test.ProcessSubString(0, 4);
            
            Assert.True(tmp.Length == 4);
        }
    }
}
