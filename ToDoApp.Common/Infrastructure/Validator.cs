using System.Collections.Generic;
using System.Linq;
using FluentValidation;
using FluentValidation.Results;
using ToDoApp.Common.Abstract;

namespace ToDoApp.Common.Infrastructure
{
    public class Validator<TModel> : IValidator<TModel, ValidationResult>
    {
        private readonly AbstractValidator<TModel> _validator;

        public Validator(AbstractValidator<TModel> validator)
        {
            _validator = validator;
        }

        public ValidationResult Validate(TModel model) => _validator.Validate(model);

        public ICollection<ValidationResult> Validate(ICollection<TModel> models) => models.Select(m => _validator.Validate(m)).ToList();

        public void ValidateAndThrow(TModel model) => _validator.ValidateAndThrow(model);

        public void ValidateAndThrow(ICollection<TModel> models)
        {
            foreach (var model in models)
            {
                _validator.ValidateAndThrow(model);
            }
        }
    }
}
