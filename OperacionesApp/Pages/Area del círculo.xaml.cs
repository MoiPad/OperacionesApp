namespace OperacionesApp.Pages;

public partial class Area_del_círculo : ContentPage
{
	public Area_del_círculo()
	{
		InitializeComponent();
	}

    private void btnCalcular(object sender, EventArgs e)
    {
        Areas areas = new Areas();

        areas.Radio = Double.Parse(txtRadio.Text);

        double resultado = areas.AreaCirculo();
        txtResultado.Text = resultado.ToString();
    }

    private void  btnLimpiar(object sender, EventArgs e)
    {
        txtRadio.Text = "";
        txtResultado.Text = "";
        txtRadio.Focus();   
    }
}