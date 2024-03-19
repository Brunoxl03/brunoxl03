namespace brunoxl;

public partial class JogoPage4 : ContentPage
{
	public JogoPage4()
	{
		InitializeComponent();
	}
    void botao6(object sender, EventArgs args)
	{
     Application.Current.MainPage = new PerdeuPage();
	}

	void botao7(object sender, EventArgs args)
	{
    Application.Current.MainPage = new JogoPage5();
    }
}