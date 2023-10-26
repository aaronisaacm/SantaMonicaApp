using SantaMonicaApp.Models;
using SantaMonicaApp.Views;
using System.Xml.Linq;

namespace SantaMonicaApp
{
    public partial class MainPage : ContentPage
    {
        List<Street> Streets;

        public MainPage()
        {
            InitializeComponent();

            Streets = new List<Street>()
            {
                new Street(){Name="Acacia Parida", ImageUrl="", Details="" },
                new Street(){Name="Avira", ImageUrl="", Details="" },
                new Street(){Name="Barahona", ImageUrl="", Details="" },
                new Street(){Name="Credos", ImageUrl="", Details="" },
                new Street(){Name="Eolo", ImageUrl="", Details="" },
                new Street(){Name="Galibi", ImageUrl="", Details="" },
                new Street(){Name="Genoveses", ImageUrl="", Details="" },
                new Street(){Name="Godino", ImageUrl="", Details="" },
                new Street(){Name="Gravina", ImageUrl="", Details="" },
                new Street(){Name="Navalon", ImageUrl="", Details="" },
                new Street(){Name="Pavero", ImageUrl="", Details="" },
                new Street(){Name="Tabor", ImageUrl="", Details="" }
            };

            streetList.ItemsSource = Streets;
        }

        private void streetList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var navigationParameter = new Dictionary<string, object>
            {
                { "SelectedStreet",  Streets[e.SelectedItemIndex].Name}
            };

            Shell.Current.GoToAsync(nameof(StreetsDetails), parameters: navigationParameter);

        }

        private void streetList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            
        }
    }

}
