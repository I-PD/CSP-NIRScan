using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISC_Win_WinForm_GUI
{
    public static class ApiClientHolder
    {
        // single shared instance
        public static readonly HttpClient Client = new HttpClient
        {
            BaseAddress = new Uri("http://127.0.0.1:8000/")
        };
    }
}
