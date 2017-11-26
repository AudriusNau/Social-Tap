using Android.Widget;
using System;
using Android.App;

namespace Fill_Up_App.Code.Exceptions
{
    class BarNameEmptyException : Exception
    {
        public BarNameEmptyException() { }
        public BarNameEmptyException(string message) : base(message)
        {
            Toast.MakeText(Application.Context, message, ToastLength.Long).Show();
        }
        public BarNameEmptyException(string message, Exception inner) : base(message, inner) { }
    }
}
