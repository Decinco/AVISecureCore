using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVIEvents
{
    public delegate void OpenForm(Form form);

    public class AVIEventHandler
    {
        public event OpenForm openForm;
    }
}
