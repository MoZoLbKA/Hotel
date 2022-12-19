using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Classes
{

    public class YearsComparer : IComparer<Visitor>
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
                if (x.Years > y.Years)
                {
                    return 1;
                }
                else if (x.Years < y.Years)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

    }
}

