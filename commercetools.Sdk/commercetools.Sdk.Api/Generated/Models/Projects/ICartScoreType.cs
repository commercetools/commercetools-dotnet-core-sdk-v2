using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Api.Models.Projects.CartScoreType))]
    public partial interface ICartScoreType : IShippingRateInputType
    {
    }
}
