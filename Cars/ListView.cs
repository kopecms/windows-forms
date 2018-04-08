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
        int filter = 0;

        public ListView()
        {
            InitializeComponent();
        }

        private void ListView_Load(object sender, EventArgs e)
        {
            this.parent = ((MainForm)this.MdiParent);
            parent.RemoveCarEvent += new System.EventHandler(this.removedCar_Event);
            parent.UpdateCarEvent += new System.EventHandler(this.updatedCar_Event);
            parent.CreateCarEvent += new System.EventHandler(this.createCar_Event);
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
            this.toolStripStatusLabel1.Text = "Cars on list: " + this.carListView.Items.Count.ToString();
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

            this.toolStripStatusLabel1.Text = "Cars on list: " + this.carListView.Items.Count.ToString();
        }
        private void updatedCar_Event(object sender, EventArgs e) {
            Car car = (Car)sender;
            
            bool flag = false;
            foreach (ListViewItem item in this.carListView.Items)
            {
                if (Object.ReferenceEquals(item.Tag,car))
                {
                    if (!this.toShow(car.MaxSpeed))
                        this.carListView.Items.Remove(item);
                    else
                    {
                        item.SubItems[0].Text = car.Brand;
                        item.SubItems[1].Text = car.MaxSpeed.ToString();
                        item.SubItems[2].Text = car.ProductionDate.ToShortDateString();
                        item.SubItems[3].Text = car.Type;
                    }
                    flag = true;
                }
            }
            if (!flag)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = car;
                item.SubItems[0].Text = car.Brand;
                item.SubItems.Add((new ListViewItem.ListViewSubItem()).Text = car.MaxSpeed.ToString());
                item.SubItems.Add((new ListViewItem.ListViewSubItem()).Text = car.ProductionDate.ToShortDateString());
                item.SubItems.Add((new ListViewItem.ListViewSubItem()).Text = car.Type);
                this.carListView.Items.Add(item);
            }
            this.toolStripStatusLabel1.Text = "Cars on list: " + this.carListView.Items.Count.ToString();
        }
        private void createCar_Event(object sender, EventArgs e)
        {
            Car car = (Car)sender;
             if (this.toShow(car.MaxSpeed))
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = car;
                    item.SubItems[0].Text = car.Brand;
                    item.SubItems.Add((new ListViewItem.ListViewSubItem()).Text = car.MaxSpeed.ToString());
                    item.SubItems.Add((new ListViewItem.ListViewSubItem()).Text = car.ProductionDate.ToShortDateString());
                    item.SubItems.Add((new ListViewItem.ListViewSubItem()).Text = car.Type);
                    this.carListView.Items.Add(item);
                }
            this.toolStripStatusLabel1.Text = "Cars on list: " + this.carListView.Items.Count.ToString();
        }
        private bool toShow(int s)
        {
            if (this.filter == 0)
                return true;
            if (this.filter == 1)
            {
                if (s <= this.speedMax && s >= this.speedMin)
                    return true;
            }
            if (this.filter == 2)
            {
                if (s > this.speedMax || s < this.speedMin)
                    return true;
            }
            return false;
        }
        private void filterButton_Click(object sender, EventArgs e)
        {
            this.carListView.Items.Clear();
            foreach (Car car in ((MainForm)this.MdiParent).GetCars())
            {
                if (this.toShow(car.MaxSpeed))
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
            this.toolStripStatusLabel1.Text = "Cars on list: " + this.carListView.Items.Count.ToString();
        }
       

        private void speedDownInput_Validating(object sender, CancelEventArgs e)
        {
            try { this.speedMin = Convert.ToInt32(speedDownInput.Text); }
            catch
            {
                e.Cancel = true;
                errorProvider.SetError(speedDownInput, "Number please.");
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
                errorProvider.SetError(speedUpInput, "Number please.");
            }
            
        }

        private void speedUpInput_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(speedUpInput, "");
        }

        private void ListView_Activated(object sender, EventArgs e)
        {
            ToolStripManager.Merge(this.statusStrip1, ((MainForm)this.MdiParent).statusStrip1);
        }

        private void ListView_Deactivate(object sender, EventArgs e)
        {
            ToolStripManager.RevertMerge(((MainForm)this.MdiParent).statusStrip1, this.statusStrip1);
        }

        private void allRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.allRadioButton.Checked)
            {
                this.filter = 0;
            }
            else if (this.inRadioButton.Checked)
            {
                this.filter = 1;
            }
            else if (this.OutRadioButton.Checked)
            {
                this.filter = 2;
            }
        }
    }
}
