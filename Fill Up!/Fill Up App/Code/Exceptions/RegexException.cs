using System;

namespace Fill_Up_App.Code.Exceptions
{
    class RegexException : Exception
    {
        public RegexException() { }
        public RegexException(string message) : base(message)
        {
            Toast.MakeText(Application.Context, message, ToastLength.Long).Show();
        }
        public RegexException(string message, Exception inner) : base(message, inner) { }
    }
}
