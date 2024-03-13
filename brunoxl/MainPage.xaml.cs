namespace brunoxl;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

  	void QuandoClicar(object sender,EventArgs args)
    {
		Application.Current.MainPage = new ComeçoPage();
	}

	void QuandoClicaNoSobre (object sender,EventArgs args)
    {
		frameAbout.IsVisible = true;
	}
	void ClicouVoltar (object sender,EventArgs args)
    {
		frameAbout.IsVisible = false;
	}
}