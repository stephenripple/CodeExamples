using System.Diagnostics;

namespace CodeExamples
{
    //Condituional Attributes are a good way to build troubleshooting/debugging code into the code base but can be excluded when packaging.
    public class ConditionalAttributes
    {

#if DEBUG
        private string _debugmessage = string.Empty;
        public string DebugMessage
        {
            get
            {
                Diagnostics();
                return _debugmessage;
            }
            set
            {
                Diagnostics();
                _debugmessage = value;
            }
        }
#endif
        private int _errornumber = 0;
        public int ErrorNumber
        {
            get
            {
                return _errornumber;
            }
            set
            {
                _errornumber = value;
            }
        }

        public ConditionalAttributes()
        {
            //I get an error instantiating the class
            _errornumber = 1;
        }

        public int DoSomething()
        {

            return _errornumber;
        }

        [Conditional("DEBUG")]
        private void Diagnostics()
        {
#if DEBUG
            if (_errornumber > 0)
                _debugmessage = "Exception Number: " + _errornumber.ToString();
            else
                _debugmessage = string.Empty;
#endif
            if (_errornumber > 0)
            {
                //Log error
            }
        }
    }
}
