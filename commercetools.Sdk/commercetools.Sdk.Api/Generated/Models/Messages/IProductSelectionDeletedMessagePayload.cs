using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ProductSelectionDeletedMessagePayload))]
    public partial interface IProductSelectionDeletedMessagePayload : IMessagePayload
    {
        ILocalizedString Name { get; set; }
    }
}
