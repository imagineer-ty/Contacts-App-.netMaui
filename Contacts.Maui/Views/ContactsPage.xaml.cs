using Contacts.Maui.Models;
using Contact = Contacts.Maui.Models.Contact;

namespace Contacts.Maui.Views;

public partial class ContactsPage : ContentPage
{
	public ContactsPage()
	{
		InitializeComponent();
        List<Contact> contacts = ContactRespository.GetContacts();
                
        listContacts.ItemsSource = contacts;
	}

    private void listContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        //if statement fixes issue of display alert needing double click
        if (listContacts.SelectedItem != null)
        {
            //tests clickable objects to make sure they work - can comment out later
            //DisplayAlert("test", "test", "ok");

            //logic
             Shell.Current.GoToAsync(nameof(EditContactPage));
        }

    }

    private void listContacts_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        //item deselection
        listContacts.SelectedItem = null;

    }
}