namespace LeaveManagement.Models
{
    public abstract class BaseClass
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
