using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomerGroupSetMessagePayload))]
    public partial interface IOrderCustomerGroupSetMessagePayload : IOrderMessagePayload
    {
        ICustomerGroupReference CustomerGroup { get; set; }

        ICustomerGroupReference OldCustomerGroup { get; set; }

    }
}
