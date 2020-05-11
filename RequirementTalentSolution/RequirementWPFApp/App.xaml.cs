using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace RequirementWPFApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static RequirementRepository.RequirementRepository _requirementRepository;

        static App()
        {
            _requirementRepository = new RequirementRepository.RequirementRepository();
        }
        public static RequirementRepository.RequirementRepository RequirementRepository
        {
            get
            {
                return _requirementRepository;
            }
        }
    }
}
