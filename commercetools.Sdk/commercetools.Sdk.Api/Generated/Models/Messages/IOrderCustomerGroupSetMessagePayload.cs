using commercetools.Api.Models.CustomerGroups;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderCustomerGroupSetMessagePayload))]
    public partial interface IOrderCustomerGroupSetMessagePayload : IMessagePayload
    {
        ICustomerGroupReference CustomerGroup { get; set;}
        
        ICustomerGroupReference OldCustomerGroup { get; set;}
    }
}
