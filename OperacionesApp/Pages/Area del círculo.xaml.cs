namespace OperacionesApp.Pages;

public partial class Area_del_círculo : ContentPage
{
	public Area_del_círculo()
	{
		InitializeComponent();
	}

    private void btnCalcular(object sender, EventArgs e)
    {
        try {
            if (Validar())
            {
                Areas areas = new Areas();

                areas.Radio = Double.Parse(txtRadio.Text);

                double resultado = areas.AreaCirculo();
                txtResultado.Text = resultado.ToString();
            }
        
        } catch (Exception) 
        {
            DisplayAlert("Advertencia!", "Se encontro un error al realizar el calculo", "Aceptar");
        }    
    }

    private void  btnLimpiar(object sender, EventArgs e)
    {
        txtRadio.Text = "";
        txtResultado.Text = "";
        txtRadio.Focus();   
    }

    private bool Validar()
    {
        if (String.IsNullOrEmpty(txtRadio.Text))
        {
            DisplayAlert("Advertencia!", "Los campos no pueden ir en blanco o vacios", "Aceptar");
            return false;
        }
        else
        {
            return true;
        }
    }
    
}