using System;

namespace VisitorAPI.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IdentityNumber { get; set; }
        public string MobileNumber { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? SeparationDate { get; set; }
        public string Department { get; set; }
        public string IdentityType { get; set; }
        public string Status { get; set; }
        public string IDImagePath { get; set; }
    }
}