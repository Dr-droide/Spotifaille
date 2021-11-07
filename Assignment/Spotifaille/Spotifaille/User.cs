using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Spotifaille
{
    public class User
    {
        private string mailAddress;
        private string passWord;

        public string MailAddress { get => mailAddress; set => mailAddress = value; }
        public string PassWord { get => passWord; set => passWord = value; }
    }
}