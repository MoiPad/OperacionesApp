namespace OperacionesApp.Pages;

public partial class Areadel_rectángulo : ContentPage
{
    public Areadel_rectángulo()
    {
        InitializeComponent();
    }

    private void txtCalcular(object sender, EventArgs e)
    {
        try
        {

            Areas areas = new Areas();
            if (Validacion())
            {
               
                areas.Longitud = Double.Parse(txtLongitud.Text);
                areas.Ancho = Double.Parse(txtAncho.Text);

                double resultado = areas.AreaRectangulo();

                txtResultado.Text = resultado.ToString();
            }
        }
        catch (Exception)
        {
            DisplayAlert("Advertencia!","Se encontro un error al realizar el calculo", "Aceptar");
        }
    }

    private void txtLimpiar(object sender, EventArgs e)
    {
        txtLongitud.Text = "";
        txtAncho.Text = "";
        txtResultado.Text = "";
        txtLongitud.Focus();

    }
    /// <summary>
    /// Validación del valor ingresado, si es nulo o vacio
    /// </summary>
    /// <returns>devuelve un mensaje si es falso, devuelve el resultado si es verdadero</returns>
    private bool Validacion()
    {
        if (string.IsNullOrEmpty(txtLongitud.Text))
        {
            DisplayAlert("Atención!", "Los campos no pueden ir en blanco, ingrese la longitud", "Aceptar");
            return false;
        }
        else if (string.IsNullOrEmpty(txtAncho.Text))
        {
            DisplayAlert("Atención!", "Los campos no pueden ir en blanco, ingrese el ancho", "Aceptar");
            return false;
        }
        else
        {
            return true;
        }

    }


  
}