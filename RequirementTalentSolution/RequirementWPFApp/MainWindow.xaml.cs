using RequirementWPFApp.Models;
using RequirementWPFApp.RelayCommand;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

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
            LoadRequirements();
            DataContext = this;

            DeleteRequirementCommand = new RelayCommand<UIRequirementModel>(OnDeleteRequirement);
            DeleteSelectedCommand = new RelayCommand<UIRequirementModel>(OnDeleteRequirement, CanDeleteRequirement);
            UpdateRequirementCommand = new RelayCommand<UIRequirementModel>(OnUpdateRequirement);
            
        }

        //Exposed Properties by the application for Binding

        public ObservableCollection<UIRequirementModel> Requirements
        {
            get { return (ObservableCollection<UIRequirementModel>)GetValue(RequirementsProperty); }
            set { SetValue(RequirementsProperty, value); }
        }
        public static readonly DependencyProperty RequirementsProperty =
            DependencyProperty.Register("Requirements", typeof(ObservableCollection<UIRequirementModel>), typeof(MainWindow), new PropertyMetadata(null));


        public UIRequirementModel SelectedRequirement
        {
            get { return (UIRequirementModel)GetValue(SelectedRequirementProperty); }
            set { SetValue(SelectedRequirementProperty, value); }
        }

        public static readonly DependencyProperty SelectedRequirementProperty =
            DependencyProperty.Register("SelectedRequirement", typeof(UIRequirementModel), typeof(MainWindow), new PropertyMetadata(null));


        //Get Requirements
        private void LoadRequirements()
        {
            var requirements = App.RequirementRepository.GetAll();
            Requirements = new ObservableCollection<UIRequirementModel>(requirements.Select(x => UIRequirementModel.ToModel(x)));
        }

        //Add a Requirement
        private void uxAdd_Click(object sender, RoutedEventArgs e)
        {
            var window = new RequirementWindow();
            if (window.ShowDialog() == true)
            {
                var uiRequirementModel = window.Requirement;
                var repositoryRequirementModel = uiRequirementModel.ToRepositoryModel();
                App.RequirementRepository.Add(repositoryRequirementModel);
                LoadRequirements();
            }
        }

        //Single Row Deletion
        public RelayCommand<UIRequirementModel> DeleteRequirementCommand
        {
            get { return (RelayCommand<UIRequirementModel>)GetValue(DeleteRequirementCommandProperty); }
            set { SetValue(DeleteRequirementCommandProperty, value); }
        }
        public static readonly DependencyProperty DeleteRequirementCommandProperty =
            DependencyProperty.Register("DeleteRequirementCommand", typeof(RelayCommand<UIRequirementModel>), typeof(MainWindow), new PropertyMetadata(null));

        private void OnDeleteRequirement(UIRequirementModel uIRequirementModel)
        {
            App.RequirementRepository.Delete(uIRequirementModel.Id);
            LoadRequirements();
        }



        //Delete From Central Collection
        public RelayCommand<UIRequirementModel> DeleteSelectedCommand
        {
            get { return (RelayCommand<UIRequirementModel>)GetValue(DeleteSelectedCommandProperty); }
            set { SetValue(DeleteSelectedCommandProperty, value); }
        }
        public static readonly DependencyProperty DeleteSelectedCommandProperty =
            DependencyProperty.Register("DeleteSelectedCommand", typeof(RelayCommand<UIRequirementModel>), typeof(MainWindow), new PropertyMetadata(null));

        private bool CanDeleteRequirement(UIRequirementModel arg)
        {
            return uxDataGrid.SelectedItem != null;
        }

        private void uxDataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            DeleteSelectedCommand.RaiseCanExecuteChanged();
        }



        //Update Single Row
        public RelayCommand<UIRequirementModel> UpdateRequirementCommand
        {
            get { return (RelayCommand<UIRequirementModel>)GetValue(UpdateRequirementCommandProperty); }
            set { SetValue(UpdateRequirementCommandProperty, value); }
        }

        public static readonly DependencyProperty UpdateRequirementCommandProperty =
            DependencyProperty.Register("UpdateRequirementCommand", typeof(RelayCommand<UIRequirementModel>), typeof(MainWindow), new PropertyMetadata(null));

        private void OnUpdateRequirement(UIRequirementModel selectedRequirement)
        {
            var window = new RequirementWindow();
            window.Requirement = selectedRequirement;
            if(window.ShowDialog()== true)
            {
                var uiRequirement = window.Requirement;
                var repositoryRequirementModel = uiRequirement.ToRepositoryModel();
                App.RequirementRepository.Update(repositoryRequirementModel);
               
            }
        }

    }
}
