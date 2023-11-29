
namespace KeyboardTabBug;

public partial class ModalPage : ContentPage
{
	public ModalPage()
	{
		InitializeComponent();
	}

	private async void CloseModal_Clicked(object sender, EventArgs e)
	{
		await Navigation.PopModalAsync();
	}
}