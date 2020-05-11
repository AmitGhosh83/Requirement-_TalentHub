using Microsoft.EntityFrameworkCore;
using RequirementDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RequirementRepository
{
    public class RequirementRepository
    {
     // Method to Convert RespositoryModel to DBModel
        private Requirement ToDbRequirementModel(RequirementModel requirementModel)
        {
            var requirementDbModel = new Requirement
            {
                Id= requirementModel.RequirementId,
                Status=requirementModel.RequirementStatus,
                Type=requirementModel.RequirementType,
                Role=requirementModel.RequirementRole,
                PositionQuantity=requirementModel.RequirementPositionQuantity,
                PrimarySkills=requirementModel.RequirementPrimarySkills,
                AdditionalSkillSet= requirementModel.RequirementAdditionalSkillSet,
                MandatorySkills= requirementModel.RequirementMandatorySkills,
                Location= requirementModel.RequirementLocation,
                CustomerName= requirementModel.RequirementCustomerName,
                CustomerEmail= requirementModel.RequirementCustomerEmail,
                Billing= requirementModel.RequirementBilling,
                Fterate= requirementModel.RequirementFteRate,
                ContractorRate= requirementModel.RequirmentContractorRate,
                RecruiterOwner=requirementModel.RequirementRecruiterOwner,
                DeliveryOwner= requirementModel.RequirementDeliveryOwner,
                SalesOwner= requirementModel.RequirementSalesOwner,
                Jd= requirementModel.RequirementJd,
                Qualification= requirementModel.RequirementQualification,
                Sonumber= requirementModel.RequirementSONumber,
                RequirementCreatedDate=requirementModel.RequirementCreatedDate
            };
            return requirementDbModel;
        }

        //Add a Repository Requirement Record
        public RequirementModel Add(RequirementModel requirementModel)
        {
            var dbRequirementModel = ToDbRequirementModel(requirementModel);
            DatabaseManager.Instance.Requirement.Add(dbRequirementModel);
            DatabaseManager.Instance.SaveChanges();

            requirementModel = new RequirementModel
            {
                RequirementId = dbRequirementModel.Id,
                RequirementStatus = dbRequirementModel.Status,
                RequirementType = dbRequirementModel.Type,
                RequirementRole = dbRequirementModel.Role,
                RequirementPositionQuantity = dbRequirementModel.PositionQuantity,
                RequirementPrimarySkills = dbRequirementModel.PrimarySkills,
                RequirementAdditionalSkillSet = dbRequirementModel.AdditionalSkillSet,
                RequirementMandatorySkills = dbRequirementModel.MandatorySkills,
                RequirementLocation = dbRequirementModel.Location,
                RequirementCustomerName = dbRequirementModel.CustomerName,
                RequirementCustomerEmail = dbRequirementModel.CustomerEmail,
                RequirementBilling = dbRequirementModel.Billing,
                RequirementFteRate = dbRequirementModel.Fterate,
                RequirmentContractorRate = dbRequirementModel.ContractorRate,
                RequirementRecruiterOwner = dbRequirementModel.RecruiterOwner,
                RequirementDeliveryOwner = dbRequirementModel.DeliveryOwner,
                RequirementSalesOwner = dbRequirementModel.SalesOwner,
                RequirementJd = dbRequirementModel.Jd,
                RequirementQualification = dbRequirementModel.Qualification,
                RequirementSONumber = dbRequirementModel.Sonumber,
                RequirementCreatedDate = dbRequirementModel.RequirementCreatedDate
            };
            return requirementModel;
        }

        //Get All Requirements
        public List<RequirementModel> GetAll()
        {
            var dbRequirementModelList = DatabaseManager.Instance.Requirement
                .Select(dbRequirementModel => new RequirementModel
                {
                    RequirementId = dbRequirementModel.Id,
                    RequirementStatus = dbRequirementModel.Status,
                    RequirementType = dbRequirementModel.Type,
                    RequirementRole = dbRequirementModel.Role,
                    RequirementPositionQuantity = dbRequirementModel.PositionQuantity,
                    RequirementPrimarySkills = dbRequirementModel.PrimarySkills,
                    RequirementAdditionalSkillSet = dbRequirementModel.AdditionalSkillSet,
                    RequirementMandatorySkills = dbRequirementModel.MandatorySkills,
                    RequirementLocation = dbRequirementModel.Location,
                    RequirementCustomerName = dbRequirementModel.CustomerName,
                    RequirementCustomerEmail = dbRequirementModel.CustomerEmail,
                    RequirementBilling = dbRequirementModel.Billing,
                    RequirementFteRate = dbRequirementModel.Fterate,
                    RequirmentContractorRate = dbRequirementModel.ContractorRate,
                    RequirementRecruiterOwner = dbRequirementModel.RecruiterOwner,
                    RequirementDeliveryOwner = dbRequirementModel.DeliveryOwner,
                    RequirementSalesOwner = dbRequirementModel.SalesOwner,
                    RequirementJd = dbRequirementModel.Jd,
                    RequirementQualification = dbRequirementModel.Qualification,
                    RequirementSONumber = dbRequirementModel.Sonumber,
                    RequirementCreatedDate = dbRequirementModel.RequirementCreatedDate
                }).ToList();
            return dbRequirementModelList;
        }

        //Update a Repository Requirment
        public bool Update(RequirementModel requirementModel)
        {
            var dbRequirementModel = ToDbRequirementModel(requirementModel);
            var itemToUpdate = DatabaseManager.Instance.Requirement.Find(requirementModel.RequirementId);
            if(itemToUpdate!= null)
            {
                DatabaseManager.Instance.Entry(dbRequirementModel).CurrentValues.SetValues(dbRequirementModel);
                DatabaseManager.Instance.SaveChanges();
                return true;
            }
            return false;
        }

        //Delete a Repository Requirement
        public bool Delete(int id)
        {
            var contactToDelete = new RequirementDB.Requirement { Id = id };
            if(contactToDelete!= null)
            {
                DatabaseManager.Instance.Entry(contactToDelete).State = EntityState.Deleted;
                DatabaseManager.Instance.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
