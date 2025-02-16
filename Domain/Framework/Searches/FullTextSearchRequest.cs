using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Framework.Searches
{
    public class FullTextSearchResult<T> : PaginatedRequest<T> where T : BaseEntity
    {
        public string SearchTerm { get; set; }
    }
}
