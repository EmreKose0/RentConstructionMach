﻿using MediatR;
using RentConstructionMach.Application.Features.Mediator.Results.BlogResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetBlogQuery : IRequest<List<GetBlogQueryResult>>
    {
    }
}
