using System;
using System.Collections.Generic;
using System.Text;

namespace BusSytem.Services.Interfaces
{
    public interface IPageList<T>
    {
 

        /// <summary>
        /// Total number of subsets within the superset.
        /// </summary>
        int TotalPages { get; set; }

        /// <summary>
        /// Total number of objects contained within the superset.
        /// </summary>
        int PageIndex { get; set; }

        public bool PreviousPage { get; set; }
        public bool NextPage { get; set; }
    }
}
