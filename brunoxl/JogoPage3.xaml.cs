namespace brunoxl;

public partial class JogoPage3 : ContentPage
{
	

	public JogoPage3()
	{
		InitializeComponent();
	}
void botao4(object sender, EventArgs args)
	{
		Application.Current.MainPage = new JogoPage4();
	}
	void botao5(object sender, EventArgs args)
	{
		Application.Current.MainPage = new PerdeuPage();
    }
}