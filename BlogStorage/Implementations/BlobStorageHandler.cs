using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogStorage.Constants;
using BlogStorage.Interfaces;
using log4net;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace BlogStorage.Implementations
{
    public class BlobStorageHandler : ServiceBase, IBlobStorageHandler
    {
        private ILog Log { get; }

        public BlobStorageHandler(ILog log) : base(log)
        {
            Log = log;
        }

        public void LogDummyInfo()
        {
            LogManagedInfo("Steven Liu", "Dummy Info", "User Create", DateTime.UtcNow.Second,"Create User","Additional message blah blah blah" );
        }

        public void LogDummyException()
        {
            var ex = new Exception("Dummy exception");
            Log.Error(ex);
        }
    }
}
