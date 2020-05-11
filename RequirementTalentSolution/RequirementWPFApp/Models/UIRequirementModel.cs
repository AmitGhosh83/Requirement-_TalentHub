using System;
using System.Collections.Generic;
using System.Text;

namespace RequirementWPFApp.Models
{
    public class UIRequirementModel
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


        //Method to Convert UIModel to RepositoryModel
        public RequirementRepository.RequirementModel ToRepositoryModel()
        {
            var repositoryModel = new RequirementRepository.RequirementModel
            {
                RequirementId =  Id,
                RequirementStatus =  Status,
                RequirementType =  Type,
                RequirementRole =  Role,
                RequirementPositionQuantity =  PositionQuantity,
                RequirementPrimarySkills =  PrimarySkills,
                RequirementAdditionalSkillSet =  AdditionalSkillSet,
                RequirementMandatorySkills =  MandatorySkills,
                RequirementLocation =  Location,
                RequirementCustomerName =  CustomerName,
                RequirementCustomerEmail =  CustomerEmail,
                RequirementBilling =  Billing,
                RequirementFteRate =  Fterate,
                RequirmentContractorRate =  ContractorRate,
                RequirementRecruiterOwner =  RecruiterOwner,
                RequirementDeliveryOwner =  DeliveryOwner,
                RequirementSalesOwner =  SalesOwner,
                RequirementJd =  Jd,
                RequirementQualification =  Qualification,
                RequirementSONumber =  Sonumber,
                RequirementCreatedDate =  RequirementCreatedDate

            };
            return repositoryModel;
        }
        //Method To Convert RepositoryModel to UIModel
        public static UIRequirementModel ToModel(RequirementRepository.RequirementModel repositorymodel)
        {
            var uiRequirementModel = new UIRequirementModel
            {
                Id = repositorymodel.RequirementId,
                Status = repositorymodel.RequirementStatus,
                Type = repositorymodel.RequirementType,
                Role = repositorymodel.RequirementRole,
                PositionQuantity = repositorymodel.RequirementPositionQuantity,
                PrimarySkills = repositorymodel.RequirementPrimarySkills,
                AdditionalSkillSet = repositorymodel.RequirementAdditionalSkillSet,
                MandatorySkills = repositorymodel.RequirementMandatorySkills,
                Location = repositorymodel.RequirementLocation,
                CustomerName = repositorymodel.RequirementCustomerName,
                CustomerEmail = repositorymodel.RequirementCustomerEmail,
                Billing = repositorymodel.RequirementBilling,
                Fterate = repositorymodel.RequirementFteRate,
                ContractorRate = repositorymodel.RequirmentContractorRate,
                RecruiterOwner = repositorymodel.RequirementRecruiterOwner,
                DeliveryOwner = repositorymodel.RequirementDeliveryOwner,
                SalesOwner = repositorymodel.RequirementSalesOwner,
                Jd = repositorymodel.RequirementJd,
                Qualification = repositorymodel.RequirementQualification,
                Sonumber = repositorymodel.RequirementSONumber,
                RequirementCreatedDate = repositorymodel.RequirementCreatedDate
            };
            return uiRequirementModel;
        }
    }
}
