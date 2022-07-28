using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductSelectionDeletedMessage))]
    public partial interface IProductSelectionDeletedMessage : IMessage
    {
        ILocalizedString Name { get; set; }

    }
}
