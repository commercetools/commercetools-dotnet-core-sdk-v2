using commercetools.Sdk.Api.Models.Types;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerGroupCustomTypeSetMessage))]
    public partial interface ICustomerGroupCustomTypeSetMessage : IMessage
    {
        ICustomFields CustomFields { get; set; }

        string OldTypeId { get; set; }

    }
}
