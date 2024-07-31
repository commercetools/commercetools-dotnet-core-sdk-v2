using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.InvalidInputError))]
    public partial interface IInvalidInputError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

    }
}
