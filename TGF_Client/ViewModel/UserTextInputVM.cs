using System;
using System.Collections.Generic;
using System.Text;

namespace TGF_Client.ViewModel
{
    class UserTextInputVM : BaseViewModel
    {
        //properties
        public string Text { get; set; }

        //constructor
        public UserTextInputVM()
        {
            Text = "Text...";
        }

    }
}
