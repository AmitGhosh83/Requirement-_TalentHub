using Microsoft.EntityFrameworkCore;
using RequirementDB;
using RequirementRepository.Model;
using System.Collections.Generic;
using System.Linq;

namespace RequirementRepository
{
    public class RequirementRepository
    {
     // Method to Convert RespositoryModel to DBModel
        private Requirement ToDbRequirementModel(RequirementModel requirementModel)
        {
            var requirementDbModel = new Requirement
            {
                Id= requirementModel.Id,
                Status=requirementModel.Status,
                Type=requirementModel.Type,
                Role=requirementModel.Role,
                PositionQuantity=requirementModel.PositionQuantity,
                PrimarySkills=requirementModel.PrimarySkills,
                AdditionalSkillSet= requirementModel.AdditionalSkillSet,
                MandatorySkills= requirementModel.MandatorySkills,
                Location= requirementModel.Location,
                CustomerName= requirementModel.CustomerName,
                CustomerEmail= requirementModel.CustomerEmail,
                Billing= requirementModel.Billing,
                Fterate= requirementModel.FteRate,
                ContractorRate= requirementModel.ContractorRate,
                RecruiterOwner=requirementModel.RecruiterOwner,
                DeliveryOwner= requirementModel.DeliveryOwner,
                SalesOwner= requirementModel.SalesOwner,
                Jd= requirementModel.Jd,
                Qualification= requirementModel.Qualification,
                Sonumber= requirementModel.SONumber,
                RequirementCreatedDate=requirementModel.CreatedDate
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
                Id = dbRequirementModel.Id,
                Status = dbRequirementModel.Status,
                Type = dbRequirementModel.Type,
                Role = dbRequirementModel.Role,
                PositionQuantity = dbRequirementModel.PositionQuantity,
                PrimarySkills = dbRequirementModel.PrimarySkills,
                AdditionalSkillSet = dbRequirementModel.AdditionalSkillSet,
                MandatorySkills = dbRequirementModel.MandatorySkills,
                Location = dbRequirementModel.Location,
                CustomerName = dbRequirementModel.CustomerName,
                CustomerEmail = dbRequirementModel.CustomerEmail,
                Billing = dbRequirementModel.Billing,
                FteRate = dbRequirementModel.Fterate,
                ContractorRate = dbRequirementModel.ContractorRate,
                RecruiterOwner = dbRequirementModel.RecruiterOwner,
                DeliveryOwner = dbRequirementModel.DeliveryOwner,
                SalesOwner = dbRequirementModel.SalesOwner,
                Jd = dbRequirementModel.Jd,
                Qualification = dbRequirementModel.Qualification,
                SONumber = dbRequirementModel.Sonumber,
                CreatedDate = dbRequirementModel.RequirementCreatedDate
            };
            return requirementModel;
        }

        //Get All Requirements
        public List<RequirementModel> GetAll()
        {
            var dbRequirementModelList = DatabaseManager.Instance.Requirement
                .Select(dbRequirementModel => new RequirementModel
                {
                    Id = dbRequirementModel.Id,
                    Status = dbRequirementModel.Status,
                    Type = dbRequirementModel.Type,
                    Role = dbRequirementModel.Role,
                    PositionQuantity = dbRequirementModel.PositionQuantity,
                    PrimarySkills = dbRequirementModel.PrimarySkills,
                    AdditionalSkillSet = dbRequirementModel.AdditionalSkillSet,
                    MandatorySkills = dbRequirementModel.MandatorySkills,
                    Location = dbRequirementModel.Location,
                    CustomerName = dbRequirementModel.CustomerName,
                    CustomerEmail = dbRequirementModel.CustomerEmail,
                    Billing = dbRequirementModel.Billing,
                    FteRate = dbRequirementModel.Fterate,
                    ContractorRate = dbRequirementModel.ContractorRate,
                    RecruiterOwner = dbRequirementModel.RecruiterOwner,
                    DeliveryOwner = dbRequirementModel.DeliveryOwner,
                    SalesOwner = dbRequirementModel.SalesOwner,
                    Jd = dbRequirementModel.Jd,
                    Qualification = dbRequirementModel.Qualification,
                    SONumber = dbRequirementModel.Sonumber,
                    CreatedDate = dbRequirementModel.RequirementCreatedDate
                }).ToList();
            return dbRequirementModelList;
        }

        //Update a Repository Requirment
        public bool Update(RequirementModel requirementModel)
        {
            var dbRequirementModel = ToDbRequirementModel(requirementModel);
            var itemToUpdate = DatabaseManager.Instance.Requirement.Find(requirementModel.Id);
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
