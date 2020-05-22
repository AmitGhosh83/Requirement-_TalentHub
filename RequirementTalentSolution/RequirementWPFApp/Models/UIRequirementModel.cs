using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using RequirementRepository.Model;
using System.Text;
using System.Text.RegularExpressions;

namespace RequirementWPFApp.Models
{
    public class UIRequirementModel : IDataErrorInfo, INotifyPropertyChanged

    {
        private static MapperConfiguration mapperConfiguration = new
            MapperConfiguration(x => x.CreateMap<UIRequirementModel, RequirementRepository.Model.RequirementModel>().ReverseMap());

        private static IMapper mapper = mapperConfiguration.CreateMapper();



        private string _role = string.Empty;
        private string _roleError=string.Empty;
        private string _status= "Open";
        private string _type= "SW";
        private int _id;
        private int _positionQuantity=1;
        private string _postionQuantityError=string.Empty;
        
        private string _primarySkills = string.Empty;
        private string _primarySkillsError=string.Empty;
        private string _additionalSkillSet;
        private string _addtionalSkillSetError= string.Empty;
        private string _mandatorySkills;
        private string _location="Redmond";
        private string _locationError=string.Empty;
        private string _customerName;
        private string _customerNameError= string.Empty;
        private string _customerEmail;
        private string _customerEmailError= string.Empty;
        private decimal _billing;
        private decimal _fterate;
        private decimal _contractorRate;
        private string _recruiterOwner="Revathi";
        private string _recruiterOwnerError=string.Empty;
        private string _deliveryOwner="Satish";
        private string _deliveryOwnerError=string.Empty;
        private string _salesOwner;
        private string _salesOwnerError= string.Empty;
        private string _jd;
        private string _qualification;
        private string _sonumber;
        private DateTime _createdDate;

        public int Id
        {
            get => _id;
            set
            {
                if (_id != value)
                    _id = value;
                OnPropertyChanged(nameof(Id));
            }
        }
        public string Type
        {
            get => _type;

            set
            {
                if (_type != value)
                    _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }
        public string Status
        {
            get { return _status; }
            set
            {
                if (_status != value)
                    _status = value;
                OnPropertyChanged(nameof(Status));

            }
        }

        public string Role
        {
            get { return _role; }
            set
            {
                if (_role != value)
                    _role = value;
                OnPropertyChanged("Role");
            }
        }
        public string RoleError
        {
            get { return _roleError; }
            set
            {
                if (_roleError != value)
                    _roleError = value;
                OnPropertyChanged("RoleError");
            }
        }

        
        public int PositionQuantity
        {
            get => _positionQuantity;
            set
            {
                if (_positionQuantity != value)
                    _positionQuantity = value;
                
                OnPropertyChanged(nameof(PositionQuantity));
            }
        }
        public string PositionQuantityError
        {
            get { return _postionQuantityError; }
            set 
            { 
               if(_postionQuantityError!=value)
                _postionQuantityError = value;
                OnPropertyChanged(PositionQuantityError);
            }
        }


        public string PrimarySkills
        {
            get => _primarySkills;
            set
            {
                if (_primarySkills != value)
                    _primarySkills = value;
                OnPropertyChanged(nameof(PrimarySkills));
            }
        }
        public string PrimarySkillsError
        {
            get { return _primarySkillsError; }
            set 
            { 
                if(_primarySkillsError!=value)
                _primarySkillsError = value;
                OnPropertyChanged(nameof(PrimarySkillsError));
            }
        }

        public string AdditionalSkillSet
        {
            get => _additionalSkillSet;
            set
            {
                if (_additionalSkillSet != value)
                    _additionalSkillSet = value;
                OnPropertyChanged(nameof(AdditionalSkillSet));
            }
        }
        public string AdditionalSkillSetError
        {
            get { return _addtionalSkillSetError; }
            set 
            {
                if(_addtionalSkillSetError!=value)
                _addtionalSkillSetError = value;
                OnPropertyChanged(nameof(AdditionalSkillSetError));
            }
        }

        public string MandatorySkills
        {
            get => _mandatorySkills;
            set
            {
                if (_mandatorySkills != value)
                    _mandatorySkills = value;
                OnPropertyChanged(nameof(MandatorySkills));
            }
        }
        public string Location
        {
            get => _location;
            set
            {
                if (_location != value)
                    _location = value;
                OnPropertyChanged(nameof(Location));
            }
        }
        public string LocationError
        {
            get { return _locationError; }
            set 
            {
                if(_locationError!=value)
                _locationError = value;
                OnPropertyChanged(nameof(LocationError));
            }
        }

        public string CustomerName
        {
            get => _customerName;
            set
            {
                if (_customerName != value)
                    _customerName = value;
                OnPropertyChanged(nameof(CustomerName));
            }
        }
        public string  CustomerNameError
        {
            get { return _customerNameError; }
            set 
            {
                if(_customerNameError!=value)
                _customerNameError = value;
                OnPropertyChanged(nameof(CustomerNameError));
            }
        }

        public string CustomerEmail
        {
            get => _customerEmail;
            set
            {
                if (_customerEmail != value)
                    _customerEmail = value;
                OnPropertyChanged(nameof(CustomerEmail));
            }
        }
        public string CustomerEmailError
        {
            get { return _customerEmailError; }
            set 
            {
                if(_customerEmailError!=value)
                _customerEmailError = value;
                OnPropertyChanged(nameof(CustomerNameError));
            }
        }

        public decimal Billing
        {
            get => _billing;
            set
            {
                if (_billing != value)
                    _billing = value;
                OnPropertyChanged(nameof(Billing));
            }
        }
        public decimal Fterate
        {
            get => _fterate;
            set
            {
                if (_fterate != value)
                    _fterate = value;
                OnPropertyChanged(nameof(Fterate));
            }
        }
        public decimal ContractorRate
        {
            get => _contractorRate;
            set
            {
                if (_contractorRate != value)
                    _contractorRate = value;
                OnPropertyChanged(nameof(ContractorRate));
            }
        }
        public string RecruiterOwner
        {
            get => _recruiterOwner;
            set
            {
                if (_recruiterOwner != value)
                    _recruiterOwner = value;
                OnPropertyChanged(nameof(RecruiterOwner));
            }
        }
        public string RecruiterOwnerError
        {
            get { return _recruiterOwnerError; }
            set 
            { 
                if(_recruiterOwnerError != value)
                _recruiterOwnerError = value;
                OnPropertyChanged(nameof(RecruiterOwnerError));
            }
        }
        public string DeliveryOwner
        {
            get => _deliveryOwner;
            set
            {
                if (_deliveryOwner != value)
                    _deliveryOwner = value;
                OnPropertyChanged(nameof(DeliveryOwner));
            }
        }
        public string DeliveryOwnerError
        {
            get { return _deliveryOwnerError; }
            set 
            { 
                if(_deliveryOwnerError!= value)
                _deliveryOwnerError = value;
                OnPropertyChanged(nameof(DeliveryOwnerError));
            }
        }

        public string SalesOwner
        {
            get => _salesOwner;
            set
            {
                if (_salesOwner != value)
                    _salesOwner = value;
                OnPropertyChanged(nameof(SalesOwner));
            }
        }
        public string SalesOwnerError
        {
            get { return _salesOwnerError; }
            set 
            {
                if(_salesOwnerError!=value)
                _salesOwnerError = value;
                OnPropertyChanged(nameof(SalesOwnerError));
            }
        }

        public string Jd
        {
            get => _jd;
            set
            {
                if (_jd != value)
                    _jd = value;
                OnPropertyChanged(nameof(Jd));
            }
        }
        public string Qualification
        {
            get => _qualification;
            set
            {
                if (_qualification != value)
                    _qualification = value;
                OnPropertyChanged(nameof(Qualification));
            }
        }
        public string Sonumber
        {
            get => _sonumber;
            set
            {
                if (_sonumber != value)
                    _sonumber = value;
                OnPropertyChanged(nameof(Sonumber));
            }
        }
        public DateTime CreatedDate
        {
            get => _createdDate; 
            set
            {
               if(_createdDate!=value)
                _createdDate = value;
                OnPropertyChanged(nameof(CreatedDate));
            }
        }

        string IDataErrorInfo.Error => RoleError;

        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case "Role":
                        {
                            RoleError = "";
                            if (string.IsNullOrEmpty(Role))
                            {
                                RoleError = "Role Cannot be Empty";
                            }
                            if (Role.Length > 20)
                            {
                                RoleError = "Role cannot be more than 20 chars";
                            }
                            return RoleError;
                        }
                    case "Location":
                        {
                            LocationError = "";
                            string regex = @"[^a - zA - Z0 - 9]";
                            if (string.IsNullOrEmpty(Location))
                            {
                                LocationError = "Mention the place of work";
                            }
                            if(!Regex.Match(Location, regex).Success)
                            {
                                LocationError = "Only alphanumeric values";
                            }
                            return LocationError;
                        }
                    case "PrimarySkills":
                        {
                            PrimarySkillsError= "";
                            
                            if (string.IsNullOrEmpty(PrimarySkills))
                            {
                                PrimarySkillsError = "Can't be empty";
                            }
                            if(PrimarySkills.Length>10)
                            {
                                PrimarySkillsError = "Keep it short (<10)";
                            }
                            return PrimarySkillsError;
                        }
                    case "CustomerName":
                        {
                            CustomerNameError = "";
                            if(string.IsNullOrEmpty(CustomerName))
                            {
                                CustomerNameError = "Cant be empty";
                            }
                            return CustomerNameError;
                        }
                    case "CustomerEmail":
                        {
                            CustomerEmailError = "";
                            if(string.IsNullOrEmpty(CustomerEmail))
                            {
                                CustomerEmailError = "Email cant be empty";
                            }
                            return CustomerEmailError;
                        }

                    case "RecruiterOwner":
                        {
                            RecruiterOwnerError = "";
                            if(string.IsNullOrEmpty(RecruiterOwner))
                            {
                                RecruiterOwnerError = "Recruiter needs to be assigned";
                            }
                            return RecruiterOwnerError;
                        }

                    case "DeliveryOwner":

                        {
                            DeliveryOwnerError = "";
                            if (string.IsNullOrEmpty(DeliveryOwner))
                            {
                                DeliveryOwnerError = "Delivery needs to be assigned";
                            }
                            return DeliveryOwnerError;
                        }

                    case "SalesOwner":
                        {
                            SalesOwnerError = "";
                            if (string.IsNullOrEmpty(SalesOwner))
                            {
                                SalesOwnerError = "Sales needs to be assigned";
                            }
                            return SalesOwner;
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
            return repositoryModel;
        }
        //Method To Convert RepositoryModel to UIModel
        public static UIRequirementModel ToModel(RequirementRepository.Model.RequirementModel repositorymodel)
        {
            var uiRequirementModel = mapper.Map<UIRequirementModel>(repositorymodel);
            return uiRequirementModel;
        }
    }
}
