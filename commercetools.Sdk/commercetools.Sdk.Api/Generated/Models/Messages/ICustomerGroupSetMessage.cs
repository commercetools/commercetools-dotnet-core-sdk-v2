using commercetools.Api.Models.CustomerGroups;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.CustomerGroupSetMessage))]
    public partial interface ICustomerGroupSetMessage : IMessage
    {
        ICustomerGroupReference CustomerGroup { get; set;}
    }
}
