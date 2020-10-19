using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.WorldOfPlanes
{
    class Plane : Aircraft
    {
        protected readonly int planeWidth = 200;
        protected readonly int planeHeight = 100;

        public Plane(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        protected Plane(int maxSpeed, float weight, Color mainColor, int planeWidth, int planeHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.planeWidth = planeWidth;
            this.planeHeight = planeHeight;
        }
        public override void Move(Direction direction)
        {
            int step = (int)(MaxSpeed * 100 / Weight);
            switch (direction)
            {
                case Direction.Left:
                    if (posX - step > 0)
                        posX -= step;
                    break;

                case Direction.Up:
                    if (posY - step > 0)
                        posY -= step;
                    break;

                case Direction.Right:
                    if (posX + step < fieldWidth - planeWidth)
                        posX += step;
                    break;

                case Direction.Down:
                    if (posY + step < fieldHeight - planeHeight)
                        posY += step;
                    break;
            }
        }
        public override void Draw(Graphics g)
        {
            SolidBrush mainBrush = new SolidBrush(MainColor);
            SolidBrush detailsBrush = new SolidBrush(Color.FromArgb(200, 200, 200));

            //хвост
            Point[] points2 =
            {
                 new Point((int)posX +8, (int)posY + 10),
                 new Point((int)posX +65, (int)posY + 15),
                 new Point((int)posX +60, (int)posY + 25),
                 new Point((int)posX +80, (int)posY + 50),
                 new Point((int)posX +55, (int)posY + 55),
                 new Point((int)posX +42, (int)posY + 22),
                 new Point((int)posX +8, (int)posY + 10),
            };
            //корпус
            Point[] points =
            {
                new Point((int)posX +50, (int)posY + 60),
                new Point((int)posX+90, (int)posY+75),
                new Point((int)posX+120, (int)posY+80),
                new Point((int)posX+185, (int)posY+70),
                new Point((int)posX+195, (int)posY+65),
                new Point((int)posX+195, (int)posY+60),
                new Point((int)posX+180, (int)posY+50),
                new Point((int)posX+170, (int)posY+50),
                new Point((int)posX+160, (int)posY+45),
                new Point((int)posX+55, (int)posY+50),
            };
            g.FillPolygon(mainBrush, points);
            g.FillPolygon(mainBrush, points2);

            // Двигатели.
            // Ближе к кобине.
            Point[] points5 =
            {
                 new Point((int)posX +100, (int)posY + 58),
                 new Point((int)posX +120, (int)posY + 70),
                 new Point((int)posX +125, (int)posY + 58),
            };
            g.FillEllipse(detailsBrush, (int)posX + 115, (int)posY + 58, 10, 12);
            g.FillPolygon(detailsBrush, points5);

            //крылья
            Point[] points3 =
            {
                new Point((int)posX +37, (int)posY + 58),
                new Point((int)posX+ 140, (int)posY + 50),
                new Point((int)posX+ 145, (int)posY + 60),
                new Point((int)posX +135, (int)posY + 64),
                new Point((int)posX +90, (int)posY + 59),
                new Point((int)posX +30, (int)posY + 65),
            };
            g.FillPolygon(detailsBrush, points3);
        }
    }
}
