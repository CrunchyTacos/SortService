using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortService.Models
{
    public class SortRepository : ISortRepository
    {
        public void sort(SortItem item)
        {
            Array.Sort(item.arr);
        }
    }
}
