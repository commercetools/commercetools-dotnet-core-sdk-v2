using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.OrderEdits.OrderEditUpdateAction))]
    [SubTypeDiscriminator("addStagedAction", typeof(commercetools.Api.Models.OrderEdits.OrderEditAddStagedActionAction))]
    [SubTypeDiscriminator("setComment", typeof(commercetools.Api.Models.OrderEdits.OrderEditSetCommentAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Api.Models.OrderEdits.OrderEditSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Api.Models.OrderEdits.OrderEditSetCustomTypeAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Api.Models.OrderEdits.OrderEditSetKeyAction))]
    [SubTypeDiscriminator("setStagedActions", typeof(commercetools.Api.Models.OrderEdits.OrderEditSetStagedActionsAction))]
    public partial interface IOrderEditUpdateAction 
    {
        string Action { get; set;}
    }
}
