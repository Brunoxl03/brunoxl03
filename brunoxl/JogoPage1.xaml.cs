namespace brunoxl;

public partial class JogoPage1 : ContentPage
{
	

	public JogoPage1()
	{
		InitializeComponent();
	}

	oid Voltar(object sender,EventArgs args)
    {
		Application.Current.MainPage = new JogoPage1();
	}

}