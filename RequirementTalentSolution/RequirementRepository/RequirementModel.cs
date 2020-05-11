using System;
using System.Collections.Generic;
using System.Text;

namespace RequirementRepository
{
    public class RequirementModel
    {
        public int RequirementId { get; set; }
        public string RequirementStatus { get; set; }
        public string RequirementType { get; set; }
        public string RequirementRole { get; set; }
        public int RequirementPositionQuantity { get; set; }
        public string RequirementPrimarySkills { get; set; }
        public string RequirementAdditionalSkillSet { get; set; }
        public string RequirementMandatorySkills { get; set; }
        public string RequirementLocation { get; set; }
        public string RequirementCustomerName { get; set; }
        public string RequirementCustomerEmail { get; set; }
        public decimal RequirementBilling { get; set; }
        public decimal RequirementFteRate { get; set; }
        public decimal RequirmentContractorRate { get; set; }
        public string RequirementRecruiterOwner { get; set; }
        public string RequirementDeliveryOwner { get; set; }
        public string RequirementSalesOwner { get; set; }
        public string RequirementJd { get; set; }
        public string RequirementQualification { get; set; }
        public string RequirementSONumber { get; set; }
        public DateTime RequirementCreatedDate { get; set; }
    }
}
