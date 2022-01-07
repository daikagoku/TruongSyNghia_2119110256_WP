using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruongSyNghia_Entity.BEL.Customer;

namespace TruongSyNghia_Entity.DAL
{
    class DatabaseBASE:DbContext
    {
        public DatabaseBASE () : base( " name = SaleDB")
        {

        }
        public DbSet<CustomerBEL> customers { get; set; }
        String defaultId = "00000000";
        public String getNewID(String lastID)
        {
            if (lastID.Equals(""))
            {
                return defaultId;
            }
            else
            {
                Boolean isIncrease = true;
                int index = lastID.Length - 1;
                char[] args = lastID.ToCharArray();
                while (isIncrease && index >= 0)
                {
                    int newI = (int)args[index] + 1;
                    if (newI == 10)
                    {
                        index--;
                        args[index] = '0';
                    }
                    else
                    {
                        args[index] = (char)newI;
                        isIncrease = false;
                    }
                }
                return new String(args);
            }
        }
    }
}
