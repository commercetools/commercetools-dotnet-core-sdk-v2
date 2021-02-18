using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [TypeDiscriminator(nameof(Action))]
    [SubTypeDiscriminator("addStagedAction", typeof(commercetools.Api.Models.OrderEdits.OrderEditAddStagedActionAction))]
    [SubTypeDiscriminator("setBillingAddressCustomField", typeof(commercetools.Api.Models.OrderEdits.OrderEditSetBillingAddressCustomFieldAction))]
    [SubTypeDiscriminator("setBillingAddressCustomType", typeof(commercetools.Api.Models.OrderEdits.OrderEditSetBillingAddressCustomTypeAction))]
    [SubTypeDiscriminator("setComment", typeof(commercetools.Api.Models.OrderEdits.OrderEditSetCommentAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Api.Models.OrderEdits.OrderEditSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Api.Models.OrderEdits.OrderEditSetCustomTypeAction))]
    [SubTypeDiscriminator("setDeliveryAddressCustomField", typeof(commercetools.Api.Models.OrderEdits.OrderEditSetDeliveryAddressCustomFieldAction))]
    [SubTypeDiscriminator("setDeliveryAddressCustomType", typeof(commercetools.Api.Models.OrderEdits.OrderEditSetDeliveryAddressCustomTypeAction))]
    [SubTypeDiscriminator("setItemShippingAddressCustomField", typeof(commercetools.Api.Models.OrderEdits.OrderEditSetItemShippingAddressCustomFieldAction))]
    [SubTypeDiscriminator("setItemShippingAddressCustomType", typeof(commercetools.Api.Models.OrderEdits.OrderEditSetItemShippingAddressCustomTypeAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Api.Models.OrderEdits.OrderEditSetKeyAction))]
    [SubTypeDiscriminator("setShippingAddressCustomField", typeof(commercetools.Api.Models.OrderEdits.OrderEditSetShippingAddressCustomFieldAction))]
    [SubTypeDiscriminator("setShippingAddressCustomType", typeof(commercetools.Api.Models.OrderEdits.OrderEditSetShippingAddressCustomTypeAction))]
    [SubTypeDiscriminator("setStagedActions", typeof(commercetools.Api.Models.OrderEdits.OrderEditSetStagedActionsAction))]
    public partial interface IOrderEditUpdateAction 
    {
        string Action { get; set;}
    }
}
