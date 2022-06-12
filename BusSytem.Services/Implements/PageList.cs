  using AutoMapper;
using BusSytem.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusSytem.Services.Implements
{
    public class PageList<T> : List<T>
    {

        public PageList(List<T> items, int count, int pageIndex, int pageSize )
        {

            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            this.AddRange(items);
        }

        public int TotalPages { get; set; }
        public int PageIndex { get; set; }
        public bool PreviousPage
        {
            get
            {
                return (PageIndex > 1);
            }
        }

        public bool NextPage
        {
            get
            {
                return (PageIndex < TotalPages);
            }
        }
        public static PageList<T> Create(IQueryable<T> query, int pageIndex, int pageSize, bool noPaging = false)
        {
            if (noPaging)
            {
                return new PageList<T>(query.ToList(), 0, 0, 0);

            }
            var count = query.Count();
            var items = query.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();

            return new PageList<T>(items, count, pageIndex, pageSize);
        }


    }

}
