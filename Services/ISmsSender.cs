using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace azurecamp_aspnet_webapp.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
