using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Dto.BlogDtos
{
    public class ResultBlogDto
    {
        public int BlogID { get; set; }
        public string Title { get; set; }
        public string CoverImgUrl { get; set; }
        public string Description { get; set; }
    }
}
