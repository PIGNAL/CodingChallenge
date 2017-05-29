
namespace CodingChallenge.ClassExtension
{
    public static class TitleExtension
    {
        public static ViewModels.TitleViewModel ConvertToViewModel(this Data.Classes.Titulo titulo)
        {
            var titleViewModel = new ViewModels.TitleViewModel
            {
                Id = titulo.Id,
                Descripcion = titulo.Descripcion,
                Detalle = titulo.Detalle,
                Moneda = (titulo.Moneda == Data.Classes.Moneda.PesoArgentino) ? "Peso Argentino" : "Dolar Americano",
                Simbolo = titulo.Simbolo,
                Tipo = (titulo.Tipo == Data.Classes.TipoTitulo.Accion) ? "Acción" : "Bono"
            };
            return titleViewModel;
        }
    }
}