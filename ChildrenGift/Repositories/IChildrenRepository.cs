using ChildrenGift.Models.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChildrenGift.Repositories
{
    public interface IChildrenRepository
    {
        Task<List<ChildDto>> GetChildren();
    }
}
