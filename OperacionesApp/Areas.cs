

namespace OperacionesApp
{
    class Areas
    {
        public double Area { get; set; }

        public double Radio { get; set; }
        public double Lado { get; set; }

        public double Longitud {  get; set; }
        public double Ancho { get; set; }

        public double AreaCirculo()
        {
            Area = Math.PI * Math.Pow(Radio, 2) ;
            return Area;
        }

        public double AreaCuadrado()
        {
            Area = Math.Pow(Lado, 2) ;
            return Area;
        }

        public double AreaRectangulo()
        {
            Area = Longitud * Ancho;
            return Area;
        }
    }
}
