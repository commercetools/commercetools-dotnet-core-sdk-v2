using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ProductSelectionDeletedMessage))]
    public partial interface IProductSelectionDeletedMessage : IMessage
    {
        ILocalizedString Name { get; set; }
    }
}
