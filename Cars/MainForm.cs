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
    public partial class MainForm : Form
    {
        public int viewCounter = 0;

        List<Car> cars = new List<Car>();

        public event EventHandler RemoveCarEvent;
        public event EventHandler UpdateCarEvent;
        public event EventHandler CreateCarEvent;

        public MainForm()
        {
            this.IsMdiContainer = true;
            InitializeComponent();

            this.cars.Add(new Car("Toyota", 300, new DateTime(2010, 1, 1), "Family"));
            this.cars.Add(new Car("Cadillac", 350, new DateTime(2010, 1, 1), "Sport"));
            this.cars.Add(new Car("Dacia", 120, new DateTime(2010, 1, 1), "Truck"));
            this.cars.Add(new Car("Audi", 399, new DateTime(2010, 1, 1), "Family"));
            this.cars.Add(new Car("Ferrari", 580, new DateTime(2010, 1, 1), "Sport"));
            this.cars.Add(new Car("Ford", 170, new DateTime(2010, 1, 1), "Truck"));
            ListView listView = new ListView();
            createListView();
        }

        public List<Car> GetCars()
        {
            return this.cars;
        }

        public void DeleteCar(Car car)
        {
            this.cars.Remove(car);
            RemoveCarEvent(car, new EventArgs());
        }

        public void AddCar(Car car)
        {
            this.cars.Add(car);
            CreateCarEvent(car, new EventArgs());
        }

        public void UpdateCar(Car car,Car updatedCar)
        {
            car.Brand = updatedCar.Brand;
            car.MaxSpeed = updatedCar.MaxSpeed;
            car.ProductionDate = updatedCar.ProductionDate;
            car.Type = updatedCar.Type;
            UpdateCarEvent(car, new EventArgs());
        }

        private void createListView()
        {
            ListView listView = new ListView();
            this.viewCounter++;
            listView.MdiParent = this;
            listView.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateDialog createDialog = new CreateDialog();
            if (createDialog.ShowDialog() == DialogResult.OK)
            {
                string brand = createDialog.branTextBox.Text;
                string type = createDialog.typeTextBox.Text;
                int maxSpeed = Convert.ToInt32(createDialog.maxSpeedTextBox.Text);
                DateTime productionDate = createDialog.dateTimePicker.Value;
                this.AddCar(new Car(brand, maxSpeed, productionDate, type));
            }
        }

        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createListView();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
