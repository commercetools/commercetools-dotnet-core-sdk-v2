using commercetools.Sdk.Api.Models.ProductSelections;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductSelectionCreatedMessagePayload))]
    public partial interface IProductSelectionCreatedMessagePayload : IMessagePayload
    {
        IProductSelection ProductSelection { get; set; }

    }
}
