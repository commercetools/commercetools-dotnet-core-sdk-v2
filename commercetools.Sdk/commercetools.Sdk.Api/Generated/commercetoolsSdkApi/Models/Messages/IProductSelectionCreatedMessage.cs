using commercetools.Sdk.Api.Models.ProductSelections;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductSelectionCreatedMessage))]
    public partial interface IProductSelectionCreatedMessage : IMessage
    {
        IProductSelection ProductSelection { get; set; }

    }
}
