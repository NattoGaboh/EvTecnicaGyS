using EvTecnicaGyS.Domain.Models;
using FluentValidation;

namespace EvTecnicaGyS.Validator
{
    public class ClientValidator: AbstractValidator<Client>
    {
        public ClientValidator()
        {
            RuleFor(x => x.CodCliente).NotNull().WithMessage("Campo {PropertyName} no debe ser nulo.")
                .NotEmpty().WithMessage("Campo {Property Name} no debe ser vacío.")
                .MaximumLength(10).WithMessage("Campo {PropertyName} máximo 10 Caracteres.");
            RuleFor(x => x.NombreCompleto).NotNull().WithMessage("Campo {PropertyName} no debe ser vacío.")
                .NotEmpty().WithMessage("Campo {Property Name} no debe ser vacío.")
                .MaximumLength(200).WithMessage("Campo {PropertyName} máximo 200 caracteres.");
            RuleFor(x => x.NombreCorto).NotNull().WithMessage("Campo {PropertyName} no debe ser vacío.")
                .NotEmpty().WithMessage("Campo {Property Name} no debe ser vacío.")
                .MaximumLength(40).WithMessage("Campo {PropertyName} máximo 40 caracteres.");
            RuleFor(x => x.Abreviatura).NotNull().WithMessage("Campo {PropertyName} no debe ser vacío.")
                .NotEmpty().WithMessage("Campo {PropertyName} no debe ser vacío.")
                .MaximumLength(40).WithMessage("Campo {PropertyName} máximo 40 caracteres");
            RuleFor(x => x.Ruc).NotNull().WithMessage("Campo {PropertyName} no debe ser vacío.")
                .NotEmpty().WithMessage("Campo {PropertyName} no debe ser vacío.")
                .MaximumLength(11).WithMessage("Campo {PropertyName} máximo 11 caracteres.");
            RuleFor(x => x.Estado).NotNull().WithMessage("Campo {PropertyName} no debe ser vacío.")
                .NotEmpty().WithMessage("Campo {PropertyName} no debe ser vacío.")
                .MaximumLength(1).WithMessage("Campo {PropertyName} máximo 1 caracter.");
            RuleFor(x => x.GrupoFacturacion).MaximumLength(100).WithMessage("Campo {PropertyName} máximo 100 caracteres");
            RuleFor(x => x.CodigoSAP).MaximumLength(20).WithMessage("Campo {PropertyName} máximo 20 caracteres.");
        }
    }
}
