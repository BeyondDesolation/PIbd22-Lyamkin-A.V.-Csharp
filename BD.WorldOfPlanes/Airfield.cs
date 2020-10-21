using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.WorldOfPlanes
{
    class Airfield<T> where T : class, ITransport
    {
        private readonly List<T> places;

        private readonly int airfieldSize;

        private readonly int fieldWidth;
        private readonly int fieldHeight;

        private const int placeWidth = 350;
        private const int placeHeight = 100;

        public Airfield(int fieldWidth, int fieldHeight)
        {
            int cols = fieldWidth / placeWidth;
            int rows = fieldHeight / placeHeight;
            places = new List<T>();
            airfieldSize = cols * rows;

            this.fieldWidth = fieldWidth;
            this.fieldHeight = fieldHeight;
        }

        public static bool operator +(Airfield<T> airfield, T plane)
        {
            if (airfield.places.Count >= airfield.airfieldSize)
                return false;

            int rows = airfield.fieldHeight / placeHeight;
            int i = airfield.places.Count;
            plane.SetPosition((i / rows) * placeWidth, (i % rows) * placeHeight, airfield.fieldWidth, airfield.fieldHeight);
            airfield.places.Add(plane);
            return true;
        }

        public static T operator -(Airfield<T> airfield, int index)
        {
            if (index >= airfield.places.Count || index < 0)
            {
                return null;
            }

            T temp = airfield.places[index];
            airfield.places.RemoveAt(index);

            int rows = airfield.fieldHeight / placeHeight;
            for (int i = 0; i < airfield.places.Count; i++)
            {
                airfield.places[i].SetPosition((i / rows) * placeWidth, (i % rows) * placeHeight, airfield.fieldWidth, airfield.fieldHeight);
            }
          
            return temp;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < places.Count; i++)
            {
                places[i].Draw(g);
            }
        }
        private void DrawMarking(Graphics g)
        {
            int rows = fieldHeight / placeHeight;
            int cols = fieldWidth / placeWidth;

            Pen pen = new Pen(Color.Black, 2);
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows + 1; ++j)
                {
                    g.DrawLine(pen, i * placeWidth, j * placeHeight, i *
                    placeWidth + placeWidth - 120, j * placeHeight);
                }
                g.DrawLine(pen, i * placeWidth, 0, i * placeWidth,
               (fieldHeight / placeHeight) * placeHeight);
            }
        }

    }
}
