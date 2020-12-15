using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.WorldOfPlanes
{
    class PlaneComparer : IComparer<Aircraft>
    {
        public int Compare(Aircraft x, Aircraft y)
        {
            
            if(x is PlaneWithRadar && y is PlaneWithRadar)
            {
                return ComparerPlaneWithRadar((PlaneWithRadar)x, (PlaneWithRadar)y);
            }
            if(y is PlaneWithRadar)
            {
                return 1;
            }
            if(x is PlaneWithRadar)
            {
                return -1;
            }
            else 
            {
                 return ComparerPlane((Plane)x, (Plane)y);
            }
            
          
        }

        private int ComparerPlane(Plane x, Plane y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }

        private int ComparerPlaneWithRadar(PlaneWithRadar x, PlaneWithRadar y)
        {
            var res = ComparerPlane(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.HasRadar != y.HasRadar)
            {
                return x.HasRadar.CompareTo(y.HasRadar);
            }
            if (x.MoreEngine != y.MoreEngine)
            {
                return x.MoreEngine.CompareTo(y.MoreEngine);
            }
            if (x.DetailsColor != y.DetailsColor)
            {
                return x.DetailsColor.Name.CompareTo(y.DetailsColor.Name);
            }
            return 0;
        }
    }
}
