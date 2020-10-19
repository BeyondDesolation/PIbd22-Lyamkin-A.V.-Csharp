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
        private readonly T[] places;

        private readonly int fieldWidth;
        private readonly int fieldHeight;

        private const int placeWidth = 350;
        private const int placeHeight = 100;

        public Airfield(int fieldWidth, int fieldHeight)
        {
            int cols = fieldWidth / placeWidth;
            int rows = fieldHeight / placeHeight;
            places = new T[rows * cols];

            this.fieldWidth = fieldWidth;
            this.fieldHeight = fieldHeight;
        }

        public static bool operator +(Airfield<T> airfield, T plane)
        {
            // int cols = airfield.fieldWidth / placeWidth;
            int rows = airfield.fieldHeight / placeHeight;

            for (int i = 0; i < airfield.places.Length; i++)
            {
                if (airfield.places[i] == null)
                {
                    plane.SetPosition((i / rows) * placeWidth, (i % rows) * placeHeight, airfield.fieldWidth, airfield.fieldHeight);
                    airfield.places[i] = plane;
                    return true;
                }
            }
            return false;
        }

        public static T operator -(Airfield<T> airfield, int index)
        {
            if (index >= airfield.places.Length || index < 0)
            {
                return null;
            }
            T temp = airfield.places[index];
            airfield.places[index] = null;

            return temp;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < places.Length; i++)
            {
                places[i]?.Draw(g);
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
