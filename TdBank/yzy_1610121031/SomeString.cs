using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TdBank.yzy_1610121031
{
    class SomeString
    {
        private string mysqlStr = "Server=111.230.237.175;port=3306;User Id=C#work;password=C#work03zu;Database=wcrb";
        private string serviceStr = "http://localhost";
        public string getMySqlStr() {
            return this.mysqlStr;
        }
        public string getServiceStr() {
            return this.serviceStr;
        }
    }
}
