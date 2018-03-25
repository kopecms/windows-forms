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
    public partial class UpdateView : Form
    {
        private Car car;
        public UpdateView(Car car)
        {
            InitializeComponent();
            this.car = car;
            this.branTextBox.Text = car.Brand;
            this.typeTextBox.Text = car.Type;
            this.maxSpeedTextBox.Text = car.MaxSpeed.ToString();
            this.dateTimePicker.Value = car.ProductionDate;
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.car.Brand = this.branTextBox.Text;
            this.car.Type = this.typeTextBox.Text;
            this.car.MaxSpeed = Convert.ToInt32(this.maxSpeedTextBox.Text);
            this.car.ProductionDate = this.dateTimePicker.Value;
            ((MainForm)this.MdiParent).UpdateCar();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).DeleteCar(this.car);
            this.Close();
        }
    }
}
