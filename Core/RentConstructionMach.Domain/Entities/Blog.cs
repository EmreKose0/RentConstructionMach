using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RentConstructionMach.Domain.Entities
{
    public class Blog
    {
        public int BlogID { get; set; }
        public string Title { get; set; }
        public string CoverImgUrl { get; set; }    
        public string Description { get; set; }
        public List<TagCloud> TagClouds { get; set; }

        
    }
}
