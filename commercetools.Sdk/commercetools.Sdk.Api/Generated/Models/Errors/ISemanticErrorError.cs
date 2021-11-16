using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.SemanticErrorError))]
    public partial interface ISemanticErrorError : IErrorObject
    {
    }
}
