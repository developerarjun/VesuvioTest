using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VesuvioTask.Services
{
    public interface IDataDetailServices
    {
        void SaveData(DataDetail d);
        bool SaveChanges();
    }
}
