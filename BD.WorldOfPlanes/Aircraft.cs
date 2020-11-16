using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.WorldOfPlanes
{
    public abstract class Aircraft : ITransport
    {
        protected float posX;
        protected float posY;

        protected int fieldWidth;
        protected int fieldHeight;

        public int MaxSpeed { protected set; get; }
        public float Weight { protected set; get; }

        public Color MainColor { protected set; get; }

        public void SetPosition(int x, int y, int width, int height)
        {
            fieldHeight = height;
            fieldWidth = width;
            posX = x;
            posY = y;
        }
        public abstract void Draw(Graphics g);
        public abstract void Move(Direction direction);

        public void SetMainColor(Color color)
        {
            MainColor = color;
        }
    }
}
