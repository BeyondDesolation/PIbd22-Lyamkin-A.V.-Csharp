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
    public partial class PlaneWithRadarForm : Form
    {
        private ITransport plane;
        private Graphics graphics;

        public PlaneWithRadarForm()
        {
            InitializeComponent();
        }
        private void Draw()
        {
            graphics.Clear(Color.FromArgb(220, 220, 250));

            plane.Draw(graphics);

            pictureBoxPlane.Refresh();
        }

        public void Start()
        {
            pictureBoxPlane.Image = new Bitmap(pictureBoxPlane.Width, pictureBoxPlane.Height);
            graphics = Graphics.FromImage(pictureBoxPlane.Image);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }

        private void bMove_click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "bMoveUp":
                    plane.Move(Direction.Up);
                    break;
                case "bMoveDown":
                    plane.Move(Direction.Down);
                    break;
                case "bMoveLeft":
                    plane.Move(Direction.Left);
                    break;
                case "bMoveRight":
                    plane.Move(Direction.Right);
                    break;
            }
            Draw();
        }

        private void bStartPlane_Click(object sender, EventArgs e)
        {
            Start();
            Random random = new Random();
            plane = new Plane
                (random.Next(100, 300),
                random.Next(1000, 2000),
                Color.FromArgb(50, 70, 140));
            plane.SetPosition(random.Next(10, 100), random.Next(10, 100), pictureBoxPlane.Width, pictureBoxPlane.Height);
            Draw();
        }

        private void bStartPlaneWithRadar_Click(object sender, EventArgs e)
        {
            Start();
            Random random = new Random();
            plane = new PlaneWithRadar
                (random.Next(100, 300),
                random.Next(1000, 2000),
                Color.FromArgb(50, 70, 140),
                Color.FromArgb(100, 150, 200),
                Color.FromArgb(230, 250, 240),
                true, true);
            plane.SetPosition(random.Next(10, 100), random.Next(10, 100), pictureBoxPlane.Width, pictureBoxPlane.Height);
            Draw();

        }
    }
}
