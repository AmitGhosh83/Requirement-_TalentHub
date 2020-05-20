using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using RequirementRepository.Model;
using System.Text;

namespace RequirementWPFApp.Models
{
    public class UIRequirementModel : IDataErrorInfo,INotifyPropertyChanged 
          
    {
        private static MapperConfiguration mapperConfiguration = new
            MapperConfiguration(x => x.CreateMap<UIRequirementModel, RequirementRepository.Model.RequirementModel>().ReverseMap());

        private static IMapper mapper = mapperConfiguration.CreateMapper();

        private string role = string.Empty;
        private string roleError;
        public int Id { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string Role
        {
            get { return role; }
            set
            {
                if(role!= value)
                role = value;
                OnPropertyChanged("Role");
            }
        }
        public string RoleError
        {
            get { return roleError; }
            set 
            { 
                if(roleError!=value)
                roleError = value;
                OnPropertyChanged("RoleError");
            }
        }

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
        public DateTime CreatedDate { get; set; }

        string IDataErrorInfo.Error => RoleError;

        public string this[string columnName]
        {
            get
            {
                switch(columnName)
                {
                    case "Role":
                        {
                            RoleError = "";
                            if(string.IsNullOrEmpty(Role))
                            {
                                RoleError = "Role Cannot be Empty";
                            }
                            if(Role.Length>3)
                            {
                                RoleError = "Role cannot be more than 3 chars";
                            }
                            return RoleError;
                        }
                }
                return null;
            }
        }

        // INotifyPropertyChanged interface
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }




        //Method to Convert UIModel to RepositoryModel
        public RequirementRepository.Model.RequirementModel ToRepositoryModel()
        {
            var repositoryModel = mapper.Map<RequirementRepository.Model.RequirementModel>(this);
            //var repositoryModel = new RequirementRepository.Model.RequirementModel
            //{
            //    Id = Id,
            //    Status = Status,
            //    Type = Type,
            //    Role = Role,
            //    PositionQuantity = PositionQuantity,
            //    PrimarySkills = PrimarySkills,
            //    AdditionalSkillSet = AdditionalSkillSet,
            //    MandatorySkills = MandatorySkills,
            //    Location = Location,
            //    CustomerName = CustomerName,
            //    CustomerEmail = CustomerEmail,
            //    Billing = Billing,
            //    FteRate = Fterate,
            //    ContractorRate = ContractorRate,
            //    RecruiterOwner = RecruiterOwner,
            //    DeliveryOwner = DeliveryOwner,
            //    SalesOwner = SalesOwner,
            //    Jd = Jd,
            //    Qualification = Qualification,
            //    SONumber = Sonumber,
            //    CreatedDate = CreatedDate

            //};
            return repositoryModel;
        }
        //Method To Convert RepositoryModel to UIModel
        public static UIRequirementModel ToModel(RequirementRepository.Model.RequirementModel repositorymodel)
        {
            var uiRequirementModel = mapper.Map<UIRequirementModel>(repositorymodel);
            //var uiRequirementModel = new UIRequirementModel
            //{
            //    Id = repositorymodel.Id,
            //    Status = repositorymodel.Status,
            //    Type = repositorymodel.Type,
            //    Role = repositorymodel. Role,
            //    PositionQuantity = repositorymodel.PositionQuantity,
            //    PrimarySkills = repositorymodel.PrimarySkills,
            //    AdditionalSkillSet = repositorymodel.AdditionalSkillSet,
            //    MandatorySkills = repositorymodel.MandatorySkills,
            //    Location = repositorymodel.Location,
            //    CustomerName = repositorymodel.CustomerName,
            //    CustomerEmail = repositorymodel.CustomerEmail,
            //    Billing = repositorymodel.Billing,
            //    Fterate = repositorymodel.FteRate,
            //    ContractorRate = repositorymodel.ContractorRate,
            //    RecruiterOwner = repositorymodel.RecruiterOwner,
            //    DeliveryOwner = repositorymodel.DeliveryOwner,
            //    SalesOwner = repositorymodel.SalesOwner,
            //    Jd = repositorymodel.Jd,
            //    Qualification = repositorymodel.Qualification,
            //    Sonumber = repositorymodel.SONumber,
            //    CreatedDate = repositorymodel.CreatedDate
            //};
            return uiRequirementModel;
        }
    }
}
