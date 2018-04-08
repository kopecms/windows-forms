using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms.Design;

namespace Cars
{
    class CarTypeEditor : System.Drawing.Design.UITypeEditor
    {
        Image sport = Image.FromFile("C:/Users/kopec/Desktop/studia/tkom/Cars/sport1.jpg");
        Image truck = Image.FromFile("C:/Users/kopec/Desktop/studia/tkom/Cars/truck.jpg");
        Image family = Image.FromFile("C:/Users/kopec/Desktop/studia/tkom/Cars/family2.jpg");
        public override void PaintValue(System.Drawing.Design.PaintValueEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.White), e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);
            if ((string)e.Value == "Sport")
                e.Graphics.DrawImage(sport, 0, 0);
            else if ((string)e.Value == "Truck")
                e.Graphics.DrawImage(truck, 0, 0);
            else if ((string)e.Value == "Family")
                e.Graphics.DrawImage(family, 0, 0);
        }

        public override bool GetPaintValueSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(
            System.ComponentModel.ITypeDescriptorContext context)
        {
            return System.Drawing.Design.UITypeEditorEditStyle.DropDown;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            IWindowsFormsEditorService edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));

            if (edSvc != null)
            {
                CarControl carTypeControl = new CarControl();
                edSvc.DropDownControl(carTypeControl);
                return carTypeControl.CarType;
            }
            return value;
        }

    }
}
