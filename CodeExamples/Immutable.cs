using System;

namespace CodeExamples
{
    public class Immutable
    {
        public string HalfImmutable
        {
            get;
            private set;
        }

        private readonly string _fullimmutable;
        public string FullImmutable
        {
            get { return _fullimmutable; }
        }

        public Immutable(string fullimmutable, string halfimmutable)
        {
            _fullimmutable = fullimmutable;
            HalfImmutable = halfimmutable;
        }

        //Demonstrate that this is not stricly an immutable object and can be changed internally after initialization
        public void InternalChange(string halfimmutable)
        {
            HalfImmutable = halfimmutable;
        }        
    }
}
