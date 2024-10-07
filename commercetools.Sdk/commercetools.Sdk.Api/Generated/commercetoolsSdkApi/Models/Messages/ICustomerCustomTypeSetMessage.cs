using commercetools.Sdk.Api.Models.Types;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerCustomTypeSetMessage))]
    public partial interface ICustomerCustomTypeSetMessage : IMessage
    {
        ICustomFields CustomFields { get; set; }

        string PreviousTypeId { get; set; }

    }
}
