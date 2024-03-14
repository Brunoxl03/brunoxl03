namespace brunoxl;

public partial class ComeçoPage : ContentPage
{
	

	public ComeçoPage()
	{
		InitializeComponent();
	}

	void Clicoubotao1(object sender,EventArgs args)
    {
		Application.Current.MainPage = new JogoPage1();
	}
	void Clicoubotao2(object sender,EventArgs args)
    {
		Application.Current.MainPage = new JogoPage2();
	}
}