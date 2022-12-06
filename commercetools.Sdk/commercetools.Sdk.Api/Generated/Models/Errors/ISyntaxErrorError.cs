using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.SyntaxErrorError))]
    public partial interface ISyntaxErrorError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

    }
}
