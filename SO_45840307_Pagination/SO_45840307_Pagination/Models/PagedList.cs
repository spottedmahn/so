using System.Collections.Generic;

namespace SO_45840307_Pagination.Models
{
    internal class PagedList<T> : List<T>, IPagedList<T>
    {
        public PagedList()
        {
        }

        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public int TotalCount { get; set; }

        public int TotalPages { get; set; }
        
        public bool HasPreviousPage { get; set; }

        public bool HasNextPage { get; set; }
    }
}