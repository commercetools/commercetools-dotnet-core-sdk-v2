using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomerGroupSetMessage))]
    public partial interface IOrderCustomerGroupSetMessage : IOrderMessage
    {
        ICustomerGroupReference CustomerGroup { get; set; }

        ICustomerGroupReference OldCustomerGroup { get; set; }

    }
}
