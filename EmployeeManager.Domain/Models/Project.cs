namespace EmployeeManager.Domain.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string? ProjectName { get; set; }
        public string? ProjectNumber { get; set; }
        public ICollection<Employee>? Employees { get; set; }
    }
}
