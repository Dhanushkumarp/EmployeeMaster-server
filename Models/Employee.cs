namespace EmployeMastersApi.Models
{
    public class Employee
    {
        public int? Id { get; set; }
        public required string Name { get; set; }
        public int? Age { get; set; }
        public required string Designation { get; set; }
        public DateTime? Dob { get; set; }
        public required string Email { get; set; }
        public required string Gender { get; set; }
        public required string Address { get; set; }
        public required string City { get; set; }
        public required string Region { get; set; }
        public required bool IsActive { get; set; }

    }
}
