using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.NoMatchingProductDiscountFoundError))]
    public partial interface INoMatchingProductDiscountFoundError : IErrorObject
    {
    }
}
