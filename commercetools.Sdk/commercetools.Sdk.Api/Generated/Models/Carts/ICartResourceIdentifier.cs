using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartResourceIdentifier))]
    public partial interface ICartResourceIdentifier : IResourceIdentifier
    {
    }
}
