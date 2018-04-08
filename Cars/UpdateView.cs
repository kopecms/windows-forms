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
        private MainForm parent;
        public UpdateView(Car car)
        {
            InitializeComponent();
            this.car = car;
            this.branTextBox.Text = car.Brand;
            this.carControl1.CarType = car.Type;
            this.maxSpeedTextBox.Text = car.MaxSpeed.ToString();
            this.dateTimePicker.Value = car.ProductionDate;
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Car updatedCar = new Car(this.branTextBox.Text,Convert.ToInt32(this.maxSpeedTextBox.Text),
                this.dateTimePicker.Value,  
                this.carControl1.CarType);
            ((MainForm)this.MdiParent).UpdateCar(this.car, updatedCar);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).DeleteCar(this.car);
            this.Close();
        }

        private void UpdateView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (((MainForm)this.MdiParent).viewCounter <= 1 && e.CloseReason != CloseReason.MdiFormClosing)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                ((MainForm)this.MdiParent).viewCounter--;
            }
        }
    }
}
