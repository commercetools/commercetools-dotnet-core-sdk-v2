using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.WeakPasswordError))]
    public partial interface IWeakPasswordError : IErrorObject
    {
    }
}
