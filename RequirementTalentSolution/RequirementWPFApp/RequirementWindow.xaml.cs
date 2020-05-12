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

            DialogResult = true;
            Close();
        }

        private void uxCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
