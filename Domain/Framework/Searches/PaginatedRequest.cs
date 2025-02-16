using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Framework.Searches
{
    public class PaginatedRequest<T> where T : BaseEntity
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }

        public IEnumerable<T> Data { get; set; }
    }
}
