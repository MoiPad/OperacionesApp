namespace OperacionesApp.Pages;

public partial class Area_del_Cuadrado : ContentPage
{
	public Area_del_Cuadrado()
	{
		InitializeComponent();
	}

    private void txtCalcular(object sender, EventArgs e)
    {
        try
        {
            if (Validar())
            { 
            Areas areas = new Areas();

            areas.Lado = Double.Parse(txtLado.Text);

            double resultado = areas.AreaCuadrado();

            txtResultado.Text = resultado.ToString();
            }
        }
        catch(Exception) 
        {
            DisplayAlert("Advertencia!", "Se encontro un error al realizar el calculo", "Aceptar");
        }
   
    }

    private void txtLimpiar(object sender, EventArgs e)
    {
        txtLado.Text = "";
        txtResultado.Text = "";
        txtLado.Focus();
    }

    private bool Validar()
    {
        if (String.IsNullOrEmpty(txtLado.Text))
        {
            DisplayAlert("Advertencia!","Los campos no pueden ir en blanco o vacios","Aceptar");
            return false;
        }
        else 
        {
            return true;
        }
    }
}