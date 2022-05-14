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
    public partial class SelectedProjectPage : ContentPage
    {
        public SelectedProjectPage(string projectName)
        {
            InitializeComponent();
            Title = projectName;
        }
    }
}