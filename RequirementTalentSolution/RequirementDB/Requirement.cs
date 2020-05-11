using System;
using System.Collections.Generic;

namespace RequirementDB
{
    public partial class Requirement
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string Role { get; set; }
        public int PositionQuantity { get; set; }
        public string PrimarySkills { get; set; }
        public string AdditionalSkillSet { get; set; }
        public string MandatorySkills { get; set; }
        public string Location { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public decimal Billing { get; set; }
        public decimal Fterate { get; set; }
        public decimal ContractorRate { get; set; }
        public string RecruiterOwner { get; set; }
        public string DeliveryOwner { get; set; }
        public string SalesOwner { get; set; }
        public string Jd { get; set; }
        public string Qualification { get; set; }
        public string Sonumber { get; set; }
        public DateTime RequirementCreatedDate { get; set; }
    }
}
