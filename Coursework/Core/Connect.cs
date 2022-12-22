using Coursework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Coursework.Core
{
    public static class Connect
    {
        public static BD_SokolEntities DB { get; set; }

        public static Frame MyFrame { get; set; }
    }
}
