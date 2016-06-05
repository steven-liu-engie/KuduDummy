using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace BlogStorage.Implementations
{
    public class ServiceBase
    {
        private ILog Log { get; }

        public ServiceBase(ILog log)
        {
            Log = log;
        }

        public void LogManagedInfo(string user, string obj, string action, int id, string title,
            string additionalMessage = null)
        {
            Log.InfoFormat("User: {0} Obj: {1} with id: {2} Title: {3} action: {4} additional: {5}",
                user, obj, id, title, action, additionalMessage);
        }
    }
}
