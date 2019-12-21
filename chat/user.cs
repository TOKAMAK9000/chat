using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chat
{
    public class user
    {
        public string userAccount="";
        public string userName="";
        public string password="";
        public string currentSending = "";

        public static user mUser = new user();
        public List<string> messageLog = new List<string>();
        
    }
    
}
