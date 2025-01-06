using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVISC_Maintenance
{
    public class ForeignKeyTag
    {
        public string ValueColumnName { get; set; }
        public string ValueTableName { get; set; }
        public string DisplayColumnName { get; set; }
        public string DisplayTableName { get; set; }

        public override string ToString()
        {
            return ValueColumnName;
        }
    }
}
