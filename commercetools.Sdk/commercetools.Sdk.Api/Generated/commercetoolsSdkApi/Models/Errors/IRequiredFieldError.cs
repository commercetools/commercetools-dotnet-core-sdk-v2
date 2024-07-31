using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.RequiredFieldError))]
    public partial interface IRequiredFieldError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        string Field { get; set; }

    }
}
