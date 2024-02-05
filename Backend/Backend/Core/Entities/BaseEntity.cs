namespace Backend.Core.Entities
{
    public class BaseEntity<TID>
    {
        //this is a generic id because id may be string long or int only that why this inheritence can make the id generic as per datatype

        public TID Id { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;


    }
}
