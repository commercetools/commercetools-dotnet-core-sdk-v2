using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.AnonymousIdAlreadyInUseError))]
    public partial interface IAnonymousIdAlreadyInUseError : IErrorObject
    {
    }
}
