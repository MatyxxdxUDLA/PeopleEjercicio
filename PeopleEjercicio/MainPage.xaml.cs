using PeopleEjercicio.Models;
using System.Collections.Generic;

namespace PeopleEjercicio
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        public async void OnNewButtonClicked(object sender, EventArgs args)
        {
            MRStatusMessage.Text = "";

            await App.PersonRepo.AddNewPerson(MRNewPerson.Text);
            MRStatusMessage.Text = App.PersonRepo.StatusMessage;
        }

        public async void OnGetButtonClicked(object sender, EventArgs args)
        {
            MRStatusMessage.Text = "";

            List<Person> people = await App.PersonRepo.GetAllPeople();
            MRPeopleList.ItemsSource = people;
        }
    }

}
