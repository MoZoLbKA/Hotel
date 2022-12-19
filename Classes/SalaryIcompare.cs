using System.Collections.Generic;

namespace Hotel.Classes
{
    public class PriceComparer : IComparer<Room>
    {
       
        int IComparer<Room>.Compare(Room x, Room y)
        {
            if (x != null && y != null)
            {
                if (x.Holder == null && y.Holder == null)
                {
                    return 0;
                }
                else if (x.Holder != null && y.Holder == null)
                {
                    return 1;
                }
                else if (x.Holder == null && y.Holder != null)
                {
                    return -1;
                }
                else
                {
                    if (x.Price > y.Price)
                    {
                        return 1;
                    }
                    else if (x.Price < y.Price)
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            else
            {
                return -1;
            }
        }
    }
}