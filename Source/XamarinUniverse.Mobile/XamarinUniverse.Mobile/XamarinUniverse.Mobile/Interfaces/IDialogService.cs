using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinUniverse.Mobile.Interfaces
{
    public interface IDialogService
    {
        void Alert(string message, string title, string okbtnText);
    }

}
