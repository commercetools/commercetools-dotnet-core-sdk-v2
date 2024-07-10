using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CustomerGroups
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupUpdateAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupChangeNameAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupSetCustomTypeAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupSetKeyAction))]
    public partial interface ICustomerGroupUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupChangeNameAction ChangeName(Action<commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupChangeNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupChangeNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupSetCustomFieldAction SetCustomField(Action<commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupSetCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupSetCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupSetCustomTypeAction SetCustomType(Action<commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupSetCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupSetCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupSetKeyAction SetKey(Action<commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupSetKeyAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupSetKeyAction();
            init?.Invoke(t);
            return t;
        }
    }
}
