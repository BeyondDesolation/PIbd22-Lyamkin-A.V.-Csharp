using System;
using System.Collections.Generic;
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
            if(index < 0 || index >= airfieldScenes.Count)
            {
                return;
            }
           
            airfieldScenes.Remove(Keys[index]);
        }
       
    }
}
