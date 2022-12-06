using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.InvalidJsonInputError))]
    public partial interface IInvalidJsonInputError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        string DetailedErrorMessage { get; set; }

    }
}
