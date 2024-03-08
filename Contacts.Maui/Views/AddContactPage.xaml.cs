namespace Contacts.Maui.Views;

public partial class AddContactPage : ContentPage
{
	public AddContactPage()
	{
		InitializeComponent();
	}

    private void btnCancel_Clicked(object sender, EventArgs e)
    {
        //line below sends you back to main page
        //line also copied to edit contact page
        Shell.Current.GoToAsync("..");

        //the code below is commented out but also works
        //sets an absolute path directly to the homepage
        //      Shell.Current.GoToAsync($"//{nameof(ContactsPage)}");


    }
}