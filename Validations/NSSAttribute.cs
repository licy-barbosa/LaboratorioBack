using System.ComponentModel.DataAnnotations;

namespace LaboratorioBack.Validations
{
    public class NSSAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            //if(value is null || string.IsNullOrEmpty(value.ToString))
            return ValidationResult.Success;
            //return new ValidationResult("mensaje de error ");

            //return base.IsValid(value, validationContext);
        }
    }
}
