namespace ChildrenGift.Models.Entities
{
    public class Gift : Entity
    {
        public string Name { get; set; }
        public int ChildId { get; set; }
        public virtual Child Child { get; set; }
    }
}
