using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.OverCapacityError))]
    public partial interface IOverCapacityError : IErrorObject
    {
    }
}
