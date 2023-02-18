using System.ComponentModel.DataAnnotations.Schema;

namespace ChildrenGift.Models.Entities
{
    public class Gift : Entity
    {
        public string Name { get; set; }
        public int ChildId { get; set; }
        [ForeignKey("ChildId")]
        public virtual Child Child { get; set; }
    }
}
