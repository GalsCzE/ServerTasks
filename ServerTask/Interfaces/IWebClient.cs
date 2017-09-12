using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServerTask.Task_Value;

namespace ServerTask.Interfaces
{
    interface IWebClient
    {
        Task<List<Headers>> GetHeadersListAsync();
    }
}
