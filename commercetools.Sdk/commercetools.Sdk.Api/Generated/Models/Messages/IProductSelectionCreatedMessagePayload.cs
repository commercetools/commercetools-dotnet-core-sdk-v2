using commercetools.Api.Models.ProductSelections;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ProductSelectionCreatedMessagePayload))]
    public partial interface IProductSelectionCreatedMessagePayload : IMessagePayload
    {
        IProductSelectionType ProductSelection { get; set; }
    }
}
