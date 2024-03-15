namespace brunoxl;

public partial class JogoPage1 : ContentPage
{
	

	public JogoPage1()
	{
		InitializeComponent();
	}

	void Voltar(object sender, EventArgs args)
	{

	}

	void Botao2(object sender, EventArgs args)
	{
		
	}
	void ClicouPerdeu(object sender, EventArgs args)
	{
		Application.Current.MainPage = new PerdeuPage();
	}
}