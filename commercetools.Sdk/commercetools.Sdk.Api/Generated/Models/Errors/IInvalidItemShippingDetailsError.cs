using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.InvalidItemShippingDetailsError))]
    public partial interface IInvalidItemShippingDetailsError : IErrorObject
    {
        string Subject { get; set;}
        
        string ItemId { get; set;}
    }
}
