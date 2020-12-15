﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.WorldOfPlanes
{
    class PlaneWithRadar : Plane, IEquatable<PlaneWithRadar>
    {
        public bool HasRadar { get; private set; }
        public bool MoreEngine { get; private set; }
        public int RadarRage { get; private set; }

        public Color DopColor { get; private set; }
        public Color DetailsColor { get; private set; }

        private SolidBrush mainBrush;
        private SolidBrush dopBrush;
        private SolidBrush detailsBrush;

        public PlaneWithRadar(int maxSpeed, int weight, Color main, Color dop, Color details, bool radar, bool moreEngine)
            : base(maxSpeed, weight, main, 200, 100)
        {
            DopColor = dop;
            DetailsColor = details;
            HasRadar = radar;
            MoreEngine = moreEngine;
        }
        public PlaneWithRadar(string info) : base(info)
        {
            string[] arrInfo = info.Split(separator);
            if (arrInfo.Length == 7)
            {
                MaxSpeed = Convert.ToInt32(arrInfo[0]);
                Weight = Convert.ToInt32(arrInfo[1]);
                MainColor = Color.FromArgb( Convert.ToInt32(arrInfo[2]));             
                DopColor = Color.FromArgb(Convert.ToInt32(arrInfo[3]));
                DetailsColor = Color.FromArgb(Convert.ToInt32(arrInfo[4]));
                HasRadar = Convert.ToBoolean(arrInfo[5]);
                MoreEngine = Convert.ToBoolean(arrInfo[6]);
               
            }
        }
        public void SetDopColor(Color color)
        {
            DopColor = color;
            DetailsColor = color;
        }

        public override void Draw(Graphics g)
        {
            mainBrush = new SolidBrush(MainColor);
            dopBrush = new SolidBrush(DopColor);
            detailsBrush = new SolidBrush(DetailsColor);
            base.Draw(g);
            // Двигатель, что ближе к хвосту.
            if (MoreEngine)
            {
                Point[] points6 =
                         {
                 new Point((int)posX +83, (int)posY + 56),
                 new Point((int)posX +103, (int)posY + 68),
                 new Point((int)posX +108, (int)posY + 56),
                 };
                g.FillPolygon(detailsBrush, points6);
                g.FillEllipse(detailsBrush, (int)posX + 98, (int)posY + 56, 10, 12);
            }
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
            g.FillPolygon(dopBrush, points3);

            // Хвост
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
            g.FillPolygon(dopBrush, points2);

            //радар
            if (HasRadar)
            {
                Point[] points4 =
               {
                new Point((int)posX +108, (int)posY + 50),
                new Point((int)posX +110, (int)posY + 35),
                new Point((int)posX +120, (int)posY + 35),
                new Point((int)posX +122, (int)posY + 50),

                 };
                g.FillPolygon(mainBrush, points4);
                g.FillEllipse(dopBrush, (int)posX + 87, (int)posY + 25, 55, 12);
            }

        }
        public override string ToString()
        {
           return
           $"{base.ToString()}{separator}{DopColor.ToArgb()}{separator}" +
           $"{DopColor.ToArgb()}{separator}{HasRadar}{separator}{MoreEngine}";
        }

        public bool Equals(PlaneWithRadar other)
        {
            if (base.Equals(other))
            {
                if(HasRadar == other.HasRadar && MoreEngine == other.MoreEngine && DopColor == other.DopColor && DetailsColor == other.DetailsColor)
                {
                    return true;
                }
            }
            return false;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is PlaneWithRadar planeObj))
            {
                return false;
            }
            else
            {
                return Equals(planeObj);
            }
        }
    }
}
