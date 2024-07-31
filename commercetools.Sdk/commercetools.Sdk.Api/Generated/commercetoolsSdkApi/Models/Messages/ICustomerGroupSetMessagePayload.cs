using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerGroupSetMessagePayload))]
    public partial interface ICustomerGroupSetMessagePayload : IMessagePayload
    {
        ICustomerGroupReference CustomerGroup { get; set; }

    }
}
