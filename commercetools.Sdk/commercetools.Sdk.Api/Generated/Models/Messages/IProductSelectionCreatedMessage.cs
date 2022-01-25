using commercetools.Api.Models.ProductSelections;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ProductSelectionCreatedMessage))]
    public partial interface IProductSelectionCreatedMessage : IMessage
    {
        IProductSelectionType ProductSelection { get; set; }
    }
}
