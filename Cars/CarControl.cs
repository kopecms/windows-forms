using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars
{
    public partial class CarControl : UserControl
    {
        private string carType;

        private Image sport;
        private Image truck;
        private Image family;

        public CarControl()
        {
            carType = "Truck";
            sport = Image.FromFile("C:/Users/kopec/Desktop/studia/tkom/Cars/sport1.jpg");
            truck = Image.FromFile("C:/Users/kopec/Desktop/studia/tkom/Cars/truck.jpg");
            family = Image.FromFile("C:/Users/kopec/Desktop/studia/tkom/Cars/family2.jpg");
            InitializeComponent();
        
        }
        [EditorAttribute(typeof(CarTypeEditor),
            typeof(System.Drawing.Design.UITypeEditor))]
        [Category("Car type control")]
        [BrowsableAttribute(true)]
        public string CarType
        {
            get { return carType; }
            set
            {
                carType = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (carType == "Sport")
                e.Graphics.DrawImage(sport, 0, 0);
            else if (carType == "Family")
                e.Graphics.DrawImage(family, 0, 0);
            else if (carType == "Truck")
                e.Graphics.DrawImage(truck, 0, 0);
        }

        protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            if (carType == "Sport")
                carType = "Truck";
            else if (carType == "Truck")
                carType = "Family";
            else if (carType == "Family")
                carType = "Sport";
            Invalidate();
        }
    }
}
