using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CustomerGroups
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.CustomerGroups.CustomerGroupUpdateAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Api.Models.CustomerGroups.CustomerGroupChangeNameAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Api.Models.CustomerGroups.CustomerGroupSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Api.Models.CustomerGroups.CustomerGroupSetCustomTypeAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Api.Models.CustomerGroups.CustomerGroupSetKeyAction))]
    public partial interface ICustomerGroupUpdateAction 
    {
        string Action { get; set;}
    }
}
