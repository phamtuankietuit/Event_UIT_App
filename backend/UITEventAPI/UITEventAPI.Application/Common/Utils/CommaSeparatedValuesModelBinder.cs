using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace UITEventAPI.Application.Common.Utils;

public class CommaSeparatedValuesModelBinder : IModelBinder
{
    public Task BindModelAsync(ModelBindingContext bindingContext)
    {
        ArgumentNullException.ThrowIfNull(bindingContext);

        var modelName = bindingContext.ModelName;

        var valueProviderResult = bindingContext.ValueProvider.GetValue(modelName);

        if (valueProviderResult == ValueProviderResult.None)
        {
            return Task.CompletedTask; // No value provided
        }

        bindingContext.ModelState.SetModelValue(modelName, valueProviderResult);

        var value = valueProviderResult.FirstValue; // Get the first value if there are multiple

        if (string.IsNullOrEmpty(value))
        {
            return Task.CompletedTask; // Empty value
        }

        var elementType = bindingContext.ModelType.IsArray
            ? bindingContext.ModelType.GetElementType()
            : bindingContext.ModelType.GenericTypeArguments.FirstOrDefault();

        if (elementType == null || !elementType.GetInterfaces().Contains(typeof(IConvertible)))
        {
            bindingContext.ModelState.TryAddModelError(
                modelName,
                $"The value '{value}' is not valid for {modelName}.");

            return Task.CompletedTask;
        }

        var values = value.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(item => Convert.ChangeType(item, elementType))
            .ToList();

        var typedValues = Array.CreateInstance(elementType, values.Count);

        values.CopyTo(typedValues.Cast<object>().ToArray(), 0);
        bindingContext.Result = ModelBindingResult.Success(typedValues);
        return Task.CompletedTask;
    }
}