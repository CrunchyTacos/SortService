using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortService.Models
{
    public interface ISortRepository
    {
        void sort(SortItem item);
    }
}
