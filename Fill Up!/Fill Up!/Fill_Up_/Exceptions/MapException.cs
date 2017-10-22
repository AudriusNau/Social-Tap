using System;

namespace Fill_Up_.Exceptions.Register
{
    class MapException : Exception
    {
        public MapException() { }
        public MapException(string message) : base(message) { }
        public MapException(string message, Exception inner) : base(message, inner) { }
    }
}
