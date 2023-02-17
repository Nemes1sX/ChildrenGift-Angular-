using System.Collections.Generic;

namespace ChildrenGift.Models.Dtos
{
    public class ChildDto : BaseDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<GiftDto> Gifts { get; set; }
    }
}
