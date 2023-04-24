using Models.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Data
{
    public static class SQL
    {
        [ThreadStatic]
        private static GymTheBeachEntities _context;

        public static string GetConnectionString()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["GymTheBeachEntities"].ConnectionString;
        }

        public static GymTheBeachEntities Context
        {
            get
            {
                if (_context == null)
                    _context = new GymTheBeachEntities();

                return _context;
            }
        }
    }
}