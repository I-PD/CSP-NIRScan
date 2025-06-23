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
        public static readonly HttpClient Client =
            new HttpClient { BaseAddress = new Uri("http://127.0.0.1:8000/") };
    }
}
