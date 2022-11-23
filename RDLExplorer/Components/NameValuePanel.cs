using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RDLExplorer.Components
{
    public partial class NameValuePanel : UserControl
    {
        public bool AutoSizeQQQQ
        {
            get;
            set;
        }

        public NameValuePanel()
        {
            AutoSize = true;
            InitializeComponent();
        }
    }
}
