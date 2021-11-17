using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VesuvioTask.Services
{
    public class DataDetailServices : IDataDetailServices
    {
        private readonly AppDbContext _context;
        public DataDetailServices(AppDbContext context)
        {
            _context = context;
        }
        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void SaveData(DataDetail d)
        {
            if (d == null)
            {
                throw new ArgumentNullException(nameof(d));
            }
            _context.datadetails.Add(d);
        }
    }
}
