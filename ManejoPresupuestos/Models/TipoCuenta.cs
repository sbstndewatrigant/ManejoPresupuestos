using ManejoPresupuestos.Validations;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ManejoPresupuestos.Models
{
    public class TipoCuenta //: IValidatableObject (para validación personalizada por modelo)
    {
        public int id { get; set; }
        //{0} se sustiye por el nombre del atributo
        [Required(ErrorMessage = "El {0} es requerido")]
        [Mayuscula]
        [Remote(action: "VerificarExisteTipoCuenta", controller: "TiposCuentas",
            AdditionalFields = nameof(id))]
        [Display(Name = "Nombre para la cuenta")]
        public string Nombre { get; set; }
        public int UsuarioId { get; set; }
        public int Orden { get; set; }

        //para validacion personalizada por modelo
        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    if (Nombre != null && Nombre.Length > 0) 
        //    {
        //        var primeraLetra = Nombre[0].ToString();

        //        if (primeraLetra != primeraLetra.ToUpper()) 
        //        {
        //            yield return new ValidationResult("La primera letra debe ser mayúscula",
        //                new[] { nameof(Nombre) });
        //        }
        //    }
        //}
    }
}
