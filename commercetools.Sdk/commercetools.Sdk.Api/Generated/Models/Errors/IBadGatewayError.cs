using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.BadGatewayError))]
    public partial interface IBadGatewayError : IErrorObject
    {
    }
}
