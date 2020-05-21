using RequirementWPFApp.Models;
using System;
using System.Windows;

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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if(Requirement!= null)
            {
                if(Requirement.Type=="SW")
                {
                    uxSW.IsChecked = true;
                }
                else
                {
                    uxHW.IsChecked = true;
                }
                if(Requirement.Status=="Open")
                {
                    uxOpen.IsChecked = true;
                }
                else
                {
                    uxClosed.IsChecked = true;
                }

                uxSubmit.Content = "Modify";
            }
            else
            {
                Requirement = new UIRequirementModel();
            }
            
            uxGrid.DataContext = Requirement;
        }

        public UIRequirementModel Requirement
        {
            get { return (UIRequirementModel)GetValue(RequirementProperty); }
            set { SetValue(RequirementProperty, value); }
        }

        public static readonly DependencyProperty RequirementProperty =
            DependencyProperty.Register("Requirement", typeof(UIRequirementModel), typeof(RequirementWindow), new PropertyMetadata(null));



        //Add Handler
        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {

            if (uxSW.IsChecked.Value)
            {
                Requirement.Type = "SW";
            }
            else
            {
                Requirement.Type = "HW";
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
            catch (Exception ex)
            {
                throw new FormatException(ex.Message + "The input is not in int format");
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
