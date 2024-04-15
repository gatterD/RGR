using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR
{
    public class AutoRegis
    {
        public SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=C:\\Users\\admin\\Desktop\\ИС-31 Марцинкевич Е.С. Георгиева Д.О\\БД\\PlantRegister.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
      
        public AutoRegis() { }

    }
}
