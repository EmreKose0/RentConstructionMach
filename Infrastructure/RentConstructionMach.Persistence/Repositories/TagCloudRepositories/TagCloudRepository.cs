using Microsoft.EntityFrameworkCore;
using RentConstructionMach.Application.Interfaces.TagCloudInterfaces;
using RentConstructionMach.Domain.Entities;
using RentConstructionMach.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Persistence.Repositories.TagCloudRepositories
{
    public class TagCloudRepository : ITagCloudRepository
    {
        private readonly RentConstructionMachContext _context;

        public TagCloudRepository(RentConstructionMachContext context)
        {
            _context = context;
        }

        public async Task<List<TagCloud>> GetTagCloudsByBlogId(int id)
        {
            var values = await _context.TagClouds.Where(x=>x.BlogID == id).ToListAsync();
            return values;
        }
    }
}
