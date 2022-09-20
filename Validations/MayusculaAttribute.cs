using System.ComponentModel.DataAnnotations;

namespace ManejoPresupuestos.Validations
{
    public class MayusculaAttribute : ValidationAttribute
    {

        //hacer una validación para que el primer caracter no pueda ir vacío
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            string nombre = value.ToString().Replace(" ", String.Empty);

            var primerCaracter = nombre.ToString()[0].ToString();

            if (nombre == value) 
            {
                if (primerCaracter != primerCaracter.ToUpper())
                {
                    return new ValidationResult("Primera letra mayuscula");
                }
            }
            else
            {
                return new ValidationResult("No deje espacios en blanco");
            }

            return ValidationResult.Success;
        }
    }
}