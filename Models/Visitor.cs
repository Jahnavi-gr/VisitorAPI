using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace VisitorAPI.Models
{
    public class Visitor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        
        [Column("visit_date")]
        public DateTime VisitDate { get; set; }

        [Column("is_blacklisted")]
        public bool IsBlacklisted { get; set; }

        [Column("company")]
        public string Company { get; set; }

        [Column("reason")]
        public string Reason { get; set; }
    }
}
