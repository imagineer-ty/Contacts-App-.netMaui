namespace Contacts.Maui.Views;

public partial class EditContactPage : ContentPage
{
	public EditContactPage()
	{
		InitializeComponent();
	}

    private void btnCancel_Clicked(object sender, EventArgs e)
    {
		//code below navigates back to parent page
		//copying this on cancel buttons on both pages 
		Shell.Current.GoToAsync("..");

        //the code below is commented out but also works
        //sets an absolute path directly to the homepage
        //      Shell.Current.GoToAsync($"//{nameof(ContactsPage)}");
    }
}