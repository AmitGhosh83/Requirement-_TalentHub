using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RequirementWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void uxFileChange_Click(object sender, RoutedEventArgs e)
        {

        }

        private void uxFileDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void uxFileNew_Click(object sender, RoutedEventArgs e)
        {
            var window = new RequirementWindow();
            if(window.ShowDialog()== true)
            {
                var uiRequirementModel = window.Requirement;
                var repositoryRequirementModel = uiRequirementModel.ToRepositoryModel();
                App.RequirementRepository.Add(repositoryRequirementModel);
            }
        }
    }
}
