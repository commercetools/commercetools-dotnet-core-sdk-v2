using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Api.Models.Projects.CartValueType))]
    public partial interface ICartValueType : IShippingRateInputType
    {
    }
}
