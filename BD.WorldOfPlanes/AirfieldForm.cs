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
        private readonly AirfieldCollection airfieldCollection;
        private Graphics graphics;

        public AirfieldForm()
        {
            InitializeComponent();
            airfieldCollection = new AirfieldCollection(pictureBoxAircraft.Width, pictureBoxAircraft.Height);
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
            if(lbExistingAirfields.SelectedIndex > -1)
            {
                graphics.Clear(Color.WhiteSmoke);
                airfieldCollection[lbExistingAirfields.SelectedItem.ToString()].Draw(graphics);
                pictureBoxAircraft.Refresh();
            }
        }

        private void ReloadLevels()
        {
            int index = lbExistingAirfields.SelectedIndex;
            lbExistingAirfields.Items.Clear();
            for (int i = 0; i < airfieldCollection.Keys.Count; i++)
            {
                lbExistingAirfields.Items.Add(airfieldCollection.Keys[i]);
            }
            if (lbExistingAirfields.Items.Count > 0 && (index == -1 || index >= lbExistingAirfields.Items.Count))
            {
                lbExistingAirfields.SelectedIndex = 0;
            }
            else if (lbExistingAirfields.Items.Count > 0 && index > -1 && index < lbExistingAirfields.Items.Count)
            {
                lbExistingAirfields.SelectedIndex = index;
            }
        }

        private void bSetPlane_Click(object sender, EventArgs e)
        {
            if(lbExistingAirfields.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var car = new Plane(100, 1000, dialog.Color);

                    if (airfieldCollection[lbExistingAirfields.SelectedItem.ToString()] + car)
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

        private void bSetPlaneWithRadar_Click(object sender, EventArgs e)
        {
            if (lbExistingAirfields.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var car = new PlaneWithRadar(100, 1000, dialog.Color, dialogDop.Color, dialogDop.Color, true, true);
                        if (airfieldCollection[lbExistingAirfields.SelectedItem.ToString()] + car)
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
        }
        private void bTakePlane_Click(object sender, EventArgs e)
        {
            if (lbExistingAirfields.SelectedIndex > -1 && maskedTextBox.Text != "")
            {
                if (maskedTextBox.Text != "")
                {
                    var car = airfieldCollection[lbExistingAirfields.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
                    if (car != null)
                    {
                        var form = new PlaneForm();
                        form.SetPlane(car);
                        form.ShowDialog();
                    }
                    Draw();
                }
            }
        }

        private void bCreateNewAirfield_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNewAirfieldName.Text))
            {
                MessageBox.Show("Введите название парковки", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            airfieldCollection.Add(tbNewAirfieldName.Text);
            ReloadLevels();
        }

        private void bDeleteAirfield_Click(object sender, EventArgs e)
        {
            if (lbExistingAirfields.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить парковку " +
                    $"{lbExistingAirfields.SelectedItem}?", "Удаление",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    airfieldCollection.Delete(lbExistingAirfields.SelectedItem.ToString());
                   
                    ReloadLevels();
                }
            }
        }

        private void lbExistingAirfields_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
