using commercetools.Api.Models.CustomerGroups;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.CustomerGroupSetMessagePayload))]
    public partial interface ICustomerGroupSetMessagePayload : IMessagePayload
    {
        ICustomerGroupReference CustomerGroup { get; set;}
    }
}
