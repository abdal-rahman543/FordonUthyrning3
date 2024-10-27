using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uthyrning.Affärslager
{   
    //Innehåller alla services som finns att använda
    // För ett mer centraliserat service register
    public static class Custom_ServiceContainer
    {
        private static readonly Dictionary<Type, object> _services = new Dictionary<Type, object>();
        public static void RegistreraService<T>(T service)
        {
            _services[typeof(T)] = service;
        }
        public static T GetService<T>()
        {
            return (T)_services[typeof(T)];
        }

    }
}
