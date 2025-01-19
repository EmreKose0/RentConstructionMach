using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.Features.Mediator.Commands.BlogCommands
{
    public class CreateBlogCommand :IRequest
    {
        public string Title { get; set; }
        public string CoverImgUrl { get; set; }
        public string Description { get; set; }
    }
}
