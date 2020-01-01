using FluentValidation.Results;
using ToDoApp.Common.Abstract;

namespace ToDoApp.Services.ValidationProxies
{
    public abstract class ServiceValidationBase<TModel>
    {
        private readonly IValidator<TModel, ValidationResult> _validator;

        public ServiceValidationBase(IValidator<TModel, ValidationResult> validator)
        {
            _validator = validator;
        }

        protected void Validate(TModel model)
        {
            _validator.ValidateAndThrow(model);
        }
    }
}