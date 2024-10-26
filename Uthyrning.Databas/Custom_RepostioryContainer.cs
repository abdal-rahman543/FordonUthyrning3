using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uthyrning.Databas
{
    public static class Custom_RepostioryContainer
    {
        private static readonly Dictionary<Type, object> _repositories = new Dictionary<Type, object>();
        public static void RegistreraService<T>(T repository)
        {
            _repositories[typeof(T)] = repository;
        }
        public static T GetRepository<T>()
        {
            return (T)_repositories[typeof(T)];
        }
    }
}
