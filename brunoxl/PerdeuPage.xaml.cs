

namespace brunoxl;

public partial class PerdeuPage : ContentPage
{
	

	public PerdeuPage()
	{
		InitializeComponent();
	}
	void ClicouVoltar(object sender, EventArgs args)
	{
		Application.Current.MainPage = new MainPage();
	}
}