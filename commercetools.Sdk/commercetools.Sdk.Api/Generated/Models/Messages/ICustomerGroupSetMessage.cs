using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerGroupSetMessage))]
    public partial interface ICustomerGroupSetMessage : IMessage
    {
        ICustomerGroupReference CustomerGroup { get; set; }
    }
}
