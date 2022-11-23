using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NRA.WinControls
{
    public partial class InputBox : Form
    {
        /// <summary>
        /// Shows the Dialog and return result
        /// </summary>
        /// <param name="title">The title.</param>
        /// <param name="prompt">The prompt.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns></returns>
        static public DialogResult Show(string title, string prompt, ref string theValue)
        {
            // Setup Form
            using (InputBox frm = new InputBox())
            {
                // Configure
                frm.Text   = title;
                frm.Prompt = prompt;
                frm.Value  = theValue;

                // Show the Dialog and save value
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    theValue = frm.Value;
                }

                return result;
            }
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        /// <summary>
        /// Gets or sets the prompt.
        /// </summary>
        /// <value>
        /// The prompt.
        /// </value>
        public string Prompt
        {
            get { return this.lblPrompt.Text; }
            set { this.lblPrompt.Text = value; }
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public string Value
        {
            get { return this.txtValue.Text; }
            set { this.txtValue.Text = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputBox"/> class.
        /// </summary>
        public InputBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Validates the form.
        /// </summary>
        /// <returns></returns>
        private bool ValidateForm()
        {
            try
            {
                if (string.IsNullOrEmpty(txtValue.Text))
                    throw new Exception("You must specify a value");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        /// <summary>
        /// Handles the Load event of the InputBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void InputBox_Load(object sender, EventArgs e)
        {
            panInput.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// Handles the Click event of the btnOK control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!this.ValidateForm())
            {
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Handles the Shown event of the InputBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void InputBox_Shown(object sender, EventArgs e)
        {
            txtValue.Focus();
        }
    }
}
