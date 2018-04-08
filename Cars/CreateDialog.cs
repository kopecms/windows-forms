using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars
{
    public partial class CreateDialog : Form
    {
        public CreateDialog()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
                DialogResult = DialogResult.OK;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CreateDialog_Load(object sender, EventArgs e)
        {

        }

        private void branTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (this.branTextBox.Text == "")
            {
                e.Cancel = true;
                errorProvider.SetError(branTextBox, "Please fill the field.");
            };
        }

        private void branTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(branTextBox, "");
        }

        private void maxSpeedTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (this.maxSpeedTextBox.Text == "")
            {
                e.Cancel = true;
                errorProvider.SetError(maxSpeedTextBox, "Please fill the field.");
            }
            else
            {
                try { Convert.ToInt32(this.maxSpeedTextBox.Text); }
                catch
                {
                    e.Cancel = true;
                    errorProvider.SetError(maxSpeedTextBox, "Number please.");
                }
            
            }
        }

        private void maxSpeedTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(maxSpeedTextBox, "");
        }
    }
}
