using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.OrderEditResourceIdentifier))]
    public partial interface IOrderEditResourceIdentifier : IResourceIdentifier
    {
    }
}
