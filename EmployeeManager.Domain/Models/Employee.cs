namespace EmployeeManager.Domain.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int CurrentProjectId { get; set; }
        public Project? CurrentProject { get; set; }
        public ICollection<EmployeeProjectHistory>? ProjectsHistory { get; set; }
    }
}
