using commercetools.Sdk.Api.Models.ProductSelections;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductSelectionCreatedMessage))]
    public partial interface IProductSelectionCreatedMessage : IMessage
    {
        IProductSelectionType ProductSelection { get; set; }

    }
}
