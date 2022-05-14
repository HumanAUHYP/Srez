using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Srez
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjectsPage : ContentPage
    {
        public ProjectStorage Projects = new ProjectStorage();
        public List<String> ProjectNames { get; set; }
        public ProjectsPage()
        {
            InitializeComponent();
            Projects.ReadFromFile(@"\projects.txt");
            FillList();
            this.BindingContext = this;
        }

        public void FillList()
        {

        }
        private async void lwProjectsItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new SelectedProjectPage(lwProjects.SelectedItem.ToString()));
        }
    }
}