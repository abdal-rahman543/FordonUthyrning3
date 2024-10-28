using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UthyrningSystem.Entiteter;

namespace Uthyrning.Entiteter
{
    public class session
    {
        private static session _instance;

        private Användare _InloggadAnvändare;

        public Användare InloggadAnvändare
        {
            get { return _InloggadAnvändare; }
        }

        public session() { }
        public static session Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new session();
                }
                return _instance;
            }
        }

        public void startSession(Användare anv)
        {
            _InloggadAnvändare = anv;
        }
        public void EndSession()
        {
            _InloggadAnvändare = null;
        }
    }
}
