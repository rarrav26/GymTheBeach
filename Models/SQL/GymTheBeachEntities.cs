using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.SQL
{
    public partial class GymTheBeachEntities : DbContext
    {
        public GymTheBeachEntities(string connectionString)
            : base("name=GymTheBeachEntities")
        {
            Database.Connection.ConnectionString = connectionString;
        }
    }
}