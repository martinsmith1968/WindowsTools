using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NRA.WinControls
{
    public partial class ExtendedTabControl : TabControl
    {
        #region Properties

        private bool showTabs = true;

        [Category("Appearance"),
        Description("Control whether the tabs are shown or hidden"),
        DefaultValue(true)]
        public bool ShowTabs
        {
            get { return showTabs; }
            set
            {
                showTabs = value;
                RecreateHandle();
            }
        }
        #endregion

        public ExtendedTabControl()
        {
            InitializeComponent();
        }

        public override Rectangle DisplayRectangle
        {
            get
            {
                if (showTabs)
                {
                    return base.DisplayRectangle;
                }
                else
                {
                    return new Rectangle(0, 0, Width, Height);
                }
            }
        }
    }
}
