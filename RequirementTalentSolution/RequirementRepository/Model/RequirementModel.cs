using System;
using System.Collections.Generic;
using System.Text;

namespace RequirementRepository.Model
{
    public class RequirementModel
    {
        public int  Id { get; set; }
        public string  Status { get; set; }
        public string  Type { get; set; }
        public string  Role { get; set; }
        public int  PositionQuantity { get; set; }
        public string  PrimarySkills { get; set; }
        public string  AdditionalSkillSet { get; set; }
        public string  MandatorySkills { get; set; }
        public string  Location { get; set; }
        public string  CustomerName { get; set; }
        public string  CustomerEmail { get; set; }
        public decimal  Billing { get; set; }
        public decimal  FteRate { get; set; }
        public decimal ContractorRate { get; set; }
        public string  RecruiterOwner { get; set; }
        public string  DeliveryOwner { get; set; }
        public string  SalesOwner { get; set; }
        public string  Jd { get; set; }
        public string  Qualification { get; set; }
        public string  SONumber { get; set; }
        public DateTime  CreatedDate { get; set; }
    }
}
