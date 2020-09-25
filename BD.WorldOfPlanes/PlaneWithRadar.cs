using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.WorldOfPlanes
{
    class PlaneWithRadar
    {
        public bool HasRadar { get; private set; }
        public bool MoreEngine { get; private set; }
        public int RadarRage { get; private set; }

        public int MaxSpeed { get; private set; }
        public int Weight { get; private set; }

        public int PosX { get; private set; }
        public int PosY { get; private set; }

        private int fieldHeight;
        private int fieldWidth;

        private const int planeHeight = 100;
        private const int planeWidth = 200;

        public Color MainColor { get; }
        public Color DopColor { get; }
        public Color DetailsBrush { get; }

        private SolidBrush mainBrush;
        private SolidBrush dopBrush;
        private SolidBrush detailsBrush;

        public PlaneWithRadar(int maxSpeed, int weight, Color main, Color dop, Color dop2, bool radar, bool moreEngine)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = main;
            DopColor = dop;
            DetailsBrush = dop2;
            HasRadar = radar;
            MoreEngine = moreEngine;

            mainBrush = new SolidBrush(MainColor);
            dopBrush = new SolidBrush(DopColor);
            detailsBrush = new SolidBrush(DetailsBrush);
        }

        public void SetPosition(int x, int y, int width, int height)
        {
            fieldHeight = height;
            fieldWidth = width;
            PosX = x;
            PosY = y;

        }

        public void MovePlane(Direction direction)
        {
            int step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Left:
                    if (PosX - step > 0)
                        PosX -= step;
                    break;

                case Direction.Up:
                    if (PosY - step > 0)
                        PosY -= step;
                    break;

                case Direction.Right:
                    if (PosX + step < fieldWidth - planeWidth)
                        PosX += step;
                    break;

                case Direction.Down:
                    if (PosY + step < fieldHeight - planeHeight)
                        PosY += step;
                    break;
            }
        }
        public void Render(Graphics g)
        {
            //хвост
            Point[] points2 =
            {
                 new Point(PosX +8, PosY + 10),
                 new Point(PosX +65, PosY + 15),
                 new Point(PosX +60, PosY + 25),
                 new Point(PosX +80, PosY + 50),
                 new Point(PosX +55, PosY + 55),
                 new Point(PosX +42, PosY + 22),
                 new Point(PosX +8, PosY + 10),

            };

            //корпус
            Point[] points =
            {
                new Point(PosX +50, PosY + 60),
                new Point(PosX+90, PosY+75),
                new Point(PosX+120, PosY+80),
                new Point(PosX+185, PosY+70),
                new Point(PosX+195, PosY+65),
                new Point(PosX+195, PosY+60),
                new Point(PosX+180, PosY+50),
                new Point(PosX+170, PosY+50),
                new Point(PosX+160, PosY+45),
                new Point(PosX+55, PosY+50),

            };
            g.FillPolygon(dopBrush, points);
            g.FillPolygon(mainBrush, points2);

            // Двигатели.
            // Ближе к кобине.
            Point[] points5 =
            {
                 new Point(PosX +100, PosY + 58),
                 new Point(PosX +120, PosY + 70),
                 new Point(PosX +125, PosY + 58),
            };
            g.FillEllipse(detailsBrush, PosX + 115, PosY + 58, 10, 12);
            g.FillPolygon(detailsBrush, points5);

            // Ближе к хвосту.
            if (MoreEngine)
            {
                Point[] points6 =
                         {
                 new Point(PosX +83, PosY + 56),
                 new Point(PosX +103, PosY + 68),
                 new Point(PosX +108, PosY + 56),
                 };
                g.FillPolygon(detailsBrush, points6);
                g.FillEllipse(detailsBrush, PosX + 98, PosY + 56, 10, 12);
            }

            //крылья
            Point[] points3 =
            {
                new Point(PosX +37, PosY + 58),
                new Point(PosX+ 140, PosY + 50),
                new Point(PosX+ 145, PosY + 60),
                new Point(PosX +135, PosY + 64),
                new Point(PosX +90, PosY + 59),
                new Point(PosX +30, PosY + 65),
            };
            g.FillPolygon(mainBrush, points3);

            //радар
            if (HasRadar)
            {
                Point[] points4 =
               {
                    new Point(PosX +108, PosY + 50),
                new Point(PosX +110, PosY + 35),
                new Point(PosX +120, PosY + 35),
                new Point(PosX +122, PosY + 50),

                 };
                g.FillPolygon(mainBrush, points4);
                g.FillEllipse(dopBrush, PosX + 87, PosY + 25, 55, 12);
            }
        }
    }
}
