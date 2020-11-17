using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.WorldOfPlanes
{
    class AirfieldCollection
    {
        readonly Dictionary<String, Airfield<Aircraft>> airfieldScenes;

        public List<String> Keys => airfieldScenes.Keys.ToList();

        public Airfield<Aircraft> this[string index]
        {
            get
            {
                List<String> l = airfieldScenes.Keys.ToList();

                if (airfieldScenes.ContainsKey(index))
                    return airfieldScenes[index];

                return null;
            }

        }
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int pictureWidth;

        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int pictureHeight;

        private readonly char separator = ':';

        public AirfieldCollection(int airfieldPictureWidth, int airfieldPictureHeight)
        {
            airfieldScenes = new Dictionary<string, Airfield<Aircraft>>();
            pictureWidth = airfieldPictureWidth;
            pictureHeight = airfieldPictureHeight;
        }
        public void Add(string name)
        {
            if (airfieldScenes.ContainsKey(name))
                return;

            airfieldScenes.Add(name, new Airfield<Aircraft>(pictureWidth, pictureHeight));
        }
        public void Delete(string name)
        {

            if (airfieldScenes.ContainsKey(name))
            {
                airfieldScenes.Remove(name);
            }
        }
        public void Delete(int index)
        {
            if (index < 0 || index >= airfieldScenes.Count)
            {
                return;
            }

            airfieldScenes.Remove(Keys[index]);
        }

        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename, true, Encoding.UTF8))
            {
                sw.WriteLine("ParkingCollection");
                foreach (var level in airfieldScenes)
                {
                    //Начинаем парковку
                    sw.WriteLine($"Parking{separator}{level.Key}");
                    ITransport plane = null;
                    for (int i = 0; (plane = level.Value.GetNext(i)) != null; i++)

                    {
                        if (plane != null)
                        {
                            //если место не пустое
                            //Записываем тип машины
                            if (plane.GetType().Name == "Plane")
                            {
                                sw.Write($"Plane{separator}");
                            }
                            if (plane.GetType().Name == "PlaneWithRadar")
                            {
                                sw.Write($"PlaneWithRadar{separator}");
                            }
                            //Записываемые параметры
                            sw.WriteLine(plane.ToString());
                        }
                    }
                }
            }
            return true;
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }

            using (StreamReader sr = new StreamReader(filename, Encoding.UTF8))
            {
                string data = sr.ReadLine();
                string key = string.Empty;
                if (data.Contains("ParkingCollection"))
                {
                    //очищаем записи
                    airfieldScenes.Clear();
                }
                else
                {
                    //если нет такой записи, то это не те данные
                    return false;
                }
                while ((data = sr.ReadLine()) != null)
                {

                    Aircraft plane = null;

                    //идем по считанным записям
                    if (data.Contains("Parking"))
                    {
                        //начинаем новую парковку
                        key = data.Split(separator)[1];
                        airfieldScenes.Add(key, new Airfield<Aircraft>(pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(data))
                    {
                        continue;
                    }
                    if (data.Split(separator)[0] == "Plane")
                    {
                        plane = new Plane(data.Split(separator)[1]);
                    }
                    else if (data.Split(separator)[0] == "PlaneWithRadar")
                    {
                        plane = new PlaneWithRadar(data.Split(separator)[1]);
                    }
                    if (!(airfieldScenes[key] + plane))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

       // Дополнительное задание
        public bool SaveAirfields(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename, true, Encoding.UTF8))
            {
                foreach (var level in airfieldScenes)
                {
                    sw.Write(level.Key + separator);            
                }
            }
            return true;
        }
        public bool LoadAirfields(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }

            using (StreamReader sr = new StreamReader(filename, Encoding.UTF8))
            {
                string[] data = sr.ReadLine().Split(separator);

                for (int i = 0; i < data.Length - 1; i++)
                {
                    airfieldScenes.Add(data[i], new Airfield<Aircraft>(pictureWidth, pictureHeight));
                }
            }
            return true;
        }
    }
}        
        
    

