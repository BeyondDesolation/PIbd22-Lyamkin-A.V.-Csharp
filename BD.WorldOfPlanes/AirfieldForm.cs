using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD.WorldOfPlanes
{
    public partial class AirfieldForm : Form
    {
        private readonly Airfield<Aircraft> airfield;
        private Graphics graphics;

        public AirfieldForm()
        {
            InitializeComponent();
            airfield = new Airfield<Aircraft>(pictureBoxAircraft.Width, pictureBoxAircraft.Height);
            InitGraphics();
            Draw();
        }

        private void InitGraphics()
        {
            pictureBoxAircraft.Image = new Bitmap(pictureBoxAircraft.Width, pictureBoxAircraft.Height);
            graphics = Graphics.FromImage(pictureBoxAircraft.Image);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }
        private void Draw()
        {
            graphics.Clear(Color.WhiteSmoke);
            airfield.Draw(graphics);
            pictureBoxAircraft.Refresh();
        }

        private void bSetPlane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var car = new Plane(100, 1000, dialog.Color);

                if (airfield + car)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Аэропорт переполнен");
                }
            }
        }

        private void bSetPlaneWithRadar_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var car = new PlaneWithRadar(100, 1000, dialog.Color, dialogDop.Color, dialogDop.Color, true, true);
                    if (airfield + car)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Аэропорт переполнен");
                    }
                }
            }
        }
        private void bTakePlane_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var car = airfield - Convert.ToInt32(maskedTextBox.Text);
                if (car != null)
                {
                    var form = new PlaneWithRadarForm();
                    form.SetPlane(car);
                    form.ShowDialog();
                }
                Draw();
            }
        }
    }
}
