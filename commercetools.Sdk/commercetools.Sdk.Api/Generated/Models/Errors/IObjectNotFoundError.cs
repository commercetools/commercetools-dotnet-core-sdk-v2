using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.ObjectNotFoundError))]
    public partial interface IObjectNotFoundError : IErrorObject
    {
    }
}
