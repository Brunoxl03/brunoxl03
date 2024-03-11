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

	void QuandoClica(object sender,EventArgs args)
    {
		
	}
}