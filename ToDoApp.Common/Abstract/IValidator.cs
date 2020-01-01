using System.Collections.Generic;

namespace ToDoApp.Common.Abstract
{
    public interface IValidator<TModel, TValidationResult>
    {
        TValidationResult Validate(TModel model);
        ICollection<TValidationResult> Validate(ICollection<TModel> models);
        void ValidateAndThrow(TModel model);
        void ValidateAndThrow(ICollection<TModel> models);
    }
}
