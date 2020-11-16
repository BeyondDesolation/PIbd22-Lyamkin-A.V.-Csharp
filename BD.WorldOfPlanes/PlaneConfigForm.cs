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
    public partial class PlaneConfigForm : Form
    {
        private Aircraft plane = null;
        private Graphics graphics;
        private event Action<Aircraft> eventCreatePlane;

        public PlaneConfigForm()
        {
            InitializeComponent();
            pbConfig.Image = new Bitmap(pbConfig.Width, pbConfig.Height);
            graphics = Graphics.FromImage(pbConfig.Image);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            bCancel.Click += (object sender, EventArgs e) => { Close(); };

            pColor1.MouseDown += pColor_MouseDown;
            pColor2.MouseDown += pColor_MouseDown;
            pColor3.MouseDown += pColor_MouseDown;
            pColor4.MouseDown += pColor_MouseDown;
            pColor5.MouseDown += pColor_MouseDown;
            pColor6.MouseDown += pColor_MouseDown;
            pColor7.MouseDown += pColor_MouseDown;
            pColor8.MouseDown += pColor_MouseDown;
        }

        private void Draw()
        {
            graphics.Clear(Color.WhiteSmoke);

            plane.Draw(graphics);

            pbConfig.Refresh();
        }

        public void AddEvent(Action<Aircraft> ev)
        {
            if (eventCreatePlane == null)
            {
                eventCreatePlane = ev;
            }
            else
            {
                eventCreatePlane += ev;
            }
        }
        private void bCreate_Click(object sender, EventArgs e)
        {
            eventCreatePlane?.Invoke(plane);
            Close();
        }

        private void pPictureBox_DragDrop(object sender, DragEventArgs e)
        {
            /* 
              switch (e.Data.GetData(DataFormats.Text).ToString())
              {
                  case "Самолет":
                      plane = new Plane((int)nudSpeed.Value, (int)nudWeight.Value, Color.White);
                      break;
                  case "Самолет с радаром":
                      plane = new PlaneWithRadar((int)nudSpeed.Value, (int)nudWeight.Value,
                          Color.White, Color.Black, Color.Black, cbHasRadar.Checked, cbMoreEngine.Checked);
                      break;
              }
            */
            if(e.Data.GetDataPresent(typeof(Plane)))
                plane = (Plane)e.Data.GetData(typeof(Plane));
            else if(e.Data.GetDataPresent(typeof(PlaneWithRadar)))
                plane = (PlaneWithRadar)e.Data.GetData(typeof(PlaneWithRadar));

            lMainColor.BackColor = Color.White;
            lDopColor.BackColor = Color.Black;
            Draw();
        }

        private void pPictureBox_DragEnter(object sender, DragEventArgs e)
        {                  
            if (e.Data.GetDataPresent(typeof(Plane)) || e.Data.GetDataPresent(typeof(PlaneWithRadar)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }           
        }

        private void lPlane_MouseDown(object sender, MouseEventArgs e)
        {
            var p = new Plane((int)nudSpeed.Value, (int)nudWeight.Value, Color.White);
            lPlane.DoDragDrop(p, DragDropEffects.Move | DragDropEffects.Copy);

            // lPlane.DoDragDrop(lPlane.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void lPlaneWithRadar_MouseDown(object sender, MouseEventArgs e)
        {
            var p = new PlaneWithRadar((int)nudSpeed.Value, (int)nudWeight.Value,
                      Color.White, Color.Black, Color.Black, cbHasRadar.Checked, cbMoreEngine.Checked);
            lPlane.DoDragDrop(p, DragDropEffects.Move | DragDropEffects.Copy);

            //lPlaneWithRadar.DoDragDrop(lPlaneWithRadar.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void pColor_MouseDown(object sender, MouseEventArgs e)
        {
           ((Panel)sender).DoDragDrop(((Panel)sender).BackColor, DragDropEffects.Move | DragDropEffects.Copy);    
           
        }

        private void lColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;           
            }
            else
            {
                e.Effect = DragDropEffects.None;              
            }       
        }

        private void lMainColor_DragDrop(object sender, DragEventArgs e)
        {
            if (plane == null)
                return;

            Color c = (Color)e.Data.GetData(typeof(Color));
            plane.SetMainColor(c);
            lMainColor.BackColor = c;
            Draw();
        }

        private void lDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (plane == null)
                return;

            if (plane is PlaneWithRadar p)
            {
                Color c = (Color)e.Data.GetData(typeof(Color));
                p.SetDopColor(c);
                lDopColor.BackColor = c;
                Draw();
            }
        }
    }
}
