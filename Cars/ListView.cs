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
    public partial class ListView : Form
    {
        
        MainForm parent;
        public ListView()
        {
            InitializeComponent();
        }

        private void ListView_Load(object sender, EventArgs e)
        {
            this.parent = ((MainForm)this.MdiParent);
            parent.RemoveCarEvent += new System.EventHandler(this.removedCar_Event);
            parent.UpdateListEvent += new System.EventHandler(this.filterButton_Click);
            foreach (Car car in this.parent.GetCars())
            {
                ListViewItem item = new ListViewItem();
                item.Tag = car;
                item.SubItems[0].Text = car.Brand;
                item.SubItems.Add((new ListViewItem.ListViewSubItem()).Text = car.MaxSpeed.ToString());
                item.SubItems.Add((new ListViewItem.ListViewSubItem()).Text = car.ProductionDate.ToShortDateString());
                item.SubItems.Add((new ListViewItem.ListViewSubItem()).Text = car.Type);
                this.carListView.Items.Add(item);
            }
        }

        public void ListView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.parent.viewCounter <= 1 && e.CloseReason != CloseReason.MdiFormClosing)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                this.parent.viewCounter--;
            }
        }

        private void carListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.carListView.SelectedItems.Count > 0)
            {
                Car car = (Car)this.carListView.SelectedItems[0].Tag;
                UpdateView updateView = new UpdateView(car);
                this.parent.viewCounter++;
                updateView.MdiParent = this.parent;
                updateView.Show();
            }
            else
            {
                MessageBox.Show("Please select car befor this operation");
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.carListView.SelectedItems.Count > 0)
            {
                Car car = (Car)this.carListView.SelectedItems[0].Tag;
                ((MainForm)this.MdiParent).DeleteCar(car);
            }
            else
            {
                MessageBox.Show("Please select car befor this operation");
            }
        }

        private void removedCar_Event(object sender, EventArgs e)
        {
            foreach (ListViewItem item in this.carListView.Items)
            {
                if (Object.ReferenceEquals(item.Tag, (Car)sender))
                {
                    this.carListView.Items.Remove(item);
                    break;
                }
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            this.carListView.Items.Clear();
            foreach (Car car in this.parent.GetCars())
            {
                if (car.MaxSpeed < this.speedMax && car.MaxSpeed > this.speedMin)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = car;
                    item.SubItems[0].Text = car.Brand;
                    item.SubItems.Add((new ListViewItem.ListViewSubItem()).Text = car.MaxSpeed.ToString());
                    item.SubItems.Add((new ListViewItem.ListViewSubItem()).Text = car.ProductionDate.ToShortDateString());
                    item.SubItems.Add((new ListViewItem.ListViewSubItem()).Text = car.Type);
                    this.carListView.Items.Add(item);
                }
            }
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void speedDownInput_Validating(object sender, CancelEventArgs e)
        {
            try { this.speedMin = Convert.ToInt32(speedDownInput.Text); }
            catch
            {
                e.Cancel = true;
                errorProvider.SetError(speedDownInput, "Wprowadź liczbę.");
            }
        }

        private void speedDownInput_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(speedDownInput, "");
        }

        private void speedUpInput_Validating(object sender, CancelEventArgs e)
        {
            try { this.speedMax = Convert.ToInt32(speedUpInput.Text); }
            catch
            {
                e.Cancel = true;
                errorProvider.SetError(speedUpInput, "Wprowadź liczbę.");
            }
            
        }

        private void speedUpInput_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(speedUpInput, "");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
