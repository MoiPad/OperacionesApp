namespace OperacionesApp.Pages;

public partial class Area_del_Cuadrado : ContentPage
{
	public Area_del_Cuadrado()
	{
		InitializeComponent();
	}

    private void txtCalcular(object sender, EventArgs e)
    {
        Areas areas = new Areas();

        areas.Lado = Double.Parse(txtLado.Text);

        double resultado = areas.AreaCuadrado();

        txtResultado.Text = resultado.ToString();
    }

    private void txtLimpiar(object sender, EventArgs e)
    {
        txtLado.Text = "";
        txtResultado.Text = "";
        txtLado.Focus();
    }
}