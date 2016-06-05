using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace BlogStorage.Interfaces
{
    public interface IBlobStorageHandler
    {
        CloudBlobContainer GetBlobContainer ();
    }
}
