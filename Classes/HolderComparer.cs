using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Classes
{
    public class HolderComparer : IComparer<Visitor>
    {
        int IComparer<Visitor>.Compare(Visitor x, Visitor y)
        {
            
            if (x == null && y == null)
            {
                return 0;
            }
            else if (x != null && y == null)
            {
                return 1;
            }
            else if (x == null && y != null)
            {
                return -1;
            }
            else
            {
                if(x.Name.Length==0 || y.Name.Length == 0)
                {
                    return 0;
                }
                if ( x.Name[0] > y.Name[0])
                {
                    return -1;
                }
                else if (x.Name[0] < y.Name[0])
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

    }
}

