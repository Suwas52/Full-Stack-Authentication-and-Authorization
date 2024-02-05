namespace Backend.Core.Entities
{
    public class Log : BaseEntity<int>
    {
        // if question marks is add this will be nullable
        public string? UserName { get; set; }
        public string Description { get; set; }   
    }
}
