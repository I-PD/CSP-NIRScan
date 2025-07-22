using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ISC_Win_WinForm_GUI
{
    internal class ApiClientHolder
    {
        public static readonly HttpClient Client;

        static ApiClientHolder()
        {
            Client = new HttpClient { BaseAddress = new Uri("http://127.0.0.1:8000/") };
            Client.Timeout = TimeSpan.FromMinutes(30); // Set to 30 minutes (adjust as needed)  
        }
    }

}
