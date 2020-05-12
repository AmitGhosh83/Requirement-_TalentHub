using RequirementWPFApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RequirementWPFApp
{
    /// <summary>
    /// Interaction logic for RequirementWindow.xaml
    /// </summary>
    public partial class RequirementWindow : Window
    {
        public RequirementWindow()
        {
            InitializeComponent();
            ShowInTaskbar = false;
        }
        public UIRequirementModel Requirement { get; set; }
        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {
            Requirement = new UIRequirementModel();
            Requirement.Role = uxRole.Text;
            Requirement.Location = uxLocation.Text;
            Requirement.PositionQuantity = ConvertStringInputToInt( uxPositionQuantity.Text);
            Requirement.PrimarySkills = uxPrimarySkills.Text;
            Requirement.AdditionalSkillSet = uxAdditionalSkills.Text;
            Requirement.CustomerName = uxCustomerName.Text;
            Requirement.CustomerEmail = uxCustomerEmail.Text;
            Requirement.RecruiterOwner = uxRecruiterOnwer.Text;
            Requirement.DeliveryOwner = uxDeliveryOwner.Text;
            Requirement.SalesOwner = uxSalesOwner.Text;
            Requirement.Billing = ConvertStringInputToDecimal(uxBilling.Text);
            Requirement.Fterate = ConvertStringInputToDecimal(uxFteRate.Text);
            Requirement.ContractorRate = ConvertStringInputToDecimal(uxContractorRate.Text);
            Requirement.Sonumber = uxSoNumber.Text;
            Requirement.Jd = uxJd.Text;
            Requirement.Qualification = uxQualification.Text;
            Requirement.MandatorySkills = uxMandatorySkills.Text;
            if(uxHW.IsChecked.Value)
            {
                Requirement.Type = "HW";
            }
            else
            {
                Requirement.Type = "SW";
            }

            if (uxOpen.IsChecked.Value)
            {
                Requirement.Status = "Open";
            }
            else
            {
                Requirement.Status = "Closed";
            }

            DialogResult = true;
            Close();
        }

        // Helper Method String--> Int
        public static int ConvertStringInputToInt(string input)
        {
            int output;
            try
            {
                int.TryParse(input, out output);
            }
            catch( Exception ex)
            {
                throw new FormatException( ex.Message+ "The input is not in int format");
            }
            return output;
        }
        //Helper Method String--> decimal
        public static decimal ConvertStringInputToDecimal(string input)
        {
            decimal output;
            try
            {
               decimal.TryParse(input, out output);
            }
            catch (Exception ex)
            {
                throw new FormatException(ex.Message + "The input is not in int format");
            }
            return output;
        }
        private void uxCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
