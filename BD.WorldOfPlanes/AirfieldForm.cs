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
            var formCarConfig = new PlaneConfigForm();
            formCarConfig.AddEvent(AddPlane);
            formCarConfig.Show();
        }
    
        private void AddPlane(Aircraft aircraft)
        {
            if (aircraft != null && lbExistingAirfields.SelectedIndex > -1)
            {
                if ((airfieldCollection[lbExistingAirfields.SelectedItem.ToString()]) + aircraft)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Аэропорт переполнен");
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

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fdSave.ShowDialog() == DialogResult.OK)
            {
                if (airfieldCollection.SaveData(fdSave.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fdOpen.ShowDialog() == DialogResult.OK)
            {
                if (airfieldCollection.LoadData(fdOpen.FileName))
                {
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    ReloadLevels();
                    Draw();
                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

       
    }
}
