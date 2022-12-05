
using FluentValidation;
using NDDTraining.Domain.DTOS;

namespace NDDTraining.Domain.Validations
{
    public class TrainingValidation : AbstractValidator<TrainingDTO>
    {

        public TrainingValidation()
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .WithMessage("Campo não pode ser vazio");
                

            RuleFor(x => x.ReleaseDate)
               .NotNull()
               .GreaterThanOrEqualTo(DateTime.Now)
               .WithMessage("Data de lançamento não pode ser no passado");



        }
    }
}
