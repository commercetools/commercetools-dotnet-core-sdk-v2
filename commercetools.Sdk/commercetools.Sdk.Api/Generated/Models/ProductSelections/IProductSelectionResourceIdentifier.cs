using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductSelections.ProductSelectionResourceIdentifier))]
    public partial interface IProductSelectionResourceIdentifier : IResourceIdentifier
    {
    }
}
