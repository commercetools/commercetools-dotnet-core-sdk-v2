using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.InvalidInputError))]
    public partial interface IInvalidInputError : IErrorObject
    {
    }
}
