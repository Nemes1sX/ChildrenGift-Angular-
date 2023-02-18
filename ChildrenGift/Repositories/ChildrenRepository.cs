using AutoMapper;
using ChildrenGift.DatContext;
using ChildrenGift.Models.Dtos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChildrenGift.Repositories
{
    public class ChildrenRepository : IChildrenRepository
    {
        private readonly ChildGiftContext _context;
        private readonly IMapper _mapper;

        public ChildrenRepository(ChildGiftContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ChildDto>> GetChildren()
        {
            var children = await _context.Children.Include(x => x.Gifts).ToListAsync();

            return _mapper.Map<List<ChildDto>>(children); 
        }
    }
}
