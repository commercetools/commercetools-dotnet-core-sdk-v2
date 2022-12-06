using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.ObjectNotFoundError))]
    public partial interface IObjectNotFoundError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

    }
}
