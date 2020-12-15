using NLog;
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
        private readonly Logger logger;

        public AirfieldForm()
        {
            InitializeComponent();
            airfieldCollection = new AirfieldCollection(pictureBoxAircraft.Width, pictureBoxAircraft.Height);
            InitGraphics();
            Draw();

            logger = LogManager.GetCurrentClassLogger();
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
                try
                {
                    if ((airfieldCollection[lbExistingAirfields.SelectedItem.ToString()]) + aircraft)
                    {
                        Draw();
                        logger.Info("Добавлен самолет " + aircraft);
                    }
                    else
                    {
                        MessageBox.Show("Аэропорт переполнен");
                    }
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show(ex.Message, "Объект не существует", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Ошибка: " + ex.Message);
                }
                catch(AirfieldOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Ошибка: " + ex.Message);
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Неизвестная ошибка: " + ex.Message);
                }
            }
        }
      
        private void bTakePlane_Click(object sender, EventArgs e)
        {
            if (lbExistingAirfields.SelectedIndex > -1 && maskedTextBox.Text != "")
            {
                if (maskedTextBox.Text != "")
                {
                    try
                    {
                        var plane = airfieldCollection[lbExistingAirfields.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
                        if (plane != null)
                        {
                            var form = new PlaneForm();
                            form.SetPlane(plane);
                            form.ShowDialog();

                            logger.Info("Изъят самолет " + plane + " с маста " + maskedTextBox.Text);
                        }
                        Draw();
                    }
                    catch(AirfieldNotFoundException ex)
                    {                    
                        MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        logger.Warn("Ошибка: " + ex.Message);

                    }
                    catch (Exception ex)
                    {                       
                        MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        logger.Warn("Неизвестная ошибка: " + ex.Message);
                    }
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

            logger.Info($"Добавили аэродром {tbNewAirfieldName.Text}");
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
                    logger.Info($"Удалили аэродром {lbExistingAirfields.SelectedItem.ToString()}"); 
                    airfieldCollection.Delete(lbExistingAirfields.SelectedItem.ToString());
                   
                    ReloadLevels();
                }
            }
        }

        private void lbExistingAirfields_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info($"Перешли на аэродром {lbExistingAirfields.SelectedItem.ToString()}");
            Draw();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fdSave.ShowDialog() == DialogResult.OK)
            {
                try
                {
                     airfieldCollection.SaveData(fdSave.FileName);
                     MessageBox.Show("Сохранение прошло успешно", "Результат",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                     logger.Info("Сохранен файл " + fdSave.FileName);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Неизвестная ошибка при сохранении: " + ex.Message);
                }
            }
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fdOpen.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    airfieldCollection.LoadData(fdOpen.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    ReloadLevels();
                    Draw();
                    logger.Info("Загружены данные из файла: " + fdOpen.FileName);
                }
                catch(FileFormatExeption ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка в формате файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Ошибка формата файла: " + ex.Message);
                }
                catch (AddingToAirfiledExeption ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при загрузе", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Ошибка при загрузке: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Неизвестная ошибка при загрузке: " + ex.Message);
                }            
            }
        }

        private void bSort_Click(object sender, EventArgs e)
        {
            if (lbExistingAirfields.SelectedIndex > -1)
            {
                airfieldCollection[lbExistingAirfields.SelectedItem.ToString()].Sort();
                Draw();
                logger.Info("Сортировка уровней");
            }
            Draw();
        }
    }
}
