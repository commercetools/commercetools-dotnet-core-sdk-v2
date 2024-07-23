using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Errors.RequiredFieldError))]
    public partial interface IRequiredFieldError : IErrorObject
    {
        string Field { get; set; }

    }
}
