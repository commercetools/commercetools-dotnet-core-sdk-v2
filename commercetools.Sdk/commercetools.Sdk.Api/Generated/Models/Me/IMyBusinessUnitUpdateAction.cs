using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Me.MyBusinessUnitUpdateAction))]
    [SubTypeDiscriminator("addAddress", typeof(commercetools.Sdk.Api.Models.Me.MyBusinessUnitAddAddressAction))]
    [SubTypeDiscriminator("addBillingAddressId", typeof(commercetools.Sdk.Api.Models.Me.MyBusinessUnitAddBillingAddressIdAction))]
    [SubTypeDiscriminator("addShippingAddressId", typeof(commercetools.Sdk.Api.Models.Me.MyBusinessUnitAddShippingAddressIdAction))]
    [SubTypeDiscriminator("changeAddress", typeof(commercetools.Sdk.Api.Models.Me.MyBusinessUnitChangeAddressAction))]
    [SubTypeDiscriminator("changeAssociate", typeof(commercetools.Sdk.Api.Models.Me.MyBusinessUnitChangeAssociateAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Sdk.Api.Models.Me.MyBusinessUnitChangeNameAction))]
    [SubTypeDiscriminator("changeParentUnit", typeof(commercetools.Sdk.Api.Models.Me.MyBusinessUnitChangeParentUnitAction))]
    [SubTypeDiscriminator("removeAddress", typeof(commercetools.Sdk.Api.Models.Me.MyBusinessUnitRemoveAddressAction))]
    [SubTypeDiscriminator("removeAssociate", typeof(commercetools.Sdk.Api.Models.Me.MyBusinessUnitRemoveAssociateAction))]
    [SubTypeDiscriminator("removeBillingAddressId", typeof(commercetools.Sdk.Api.Models.Me.MyBusinessUnitRemoveBillingAddressIdAction))]
    [SubTypeDiscriminator("removeShippingAddressId", typeof(commercetools.Sdk.Api.Models.Me.MyBusinessUnitRemoveShippingAddressIdAction))]
    [SubTypeDiscriminator("setAddressCustomField", typeof(commercetools.Sdk.Api.Models.Me.MyBusinessUnitSetAddressCustomFieldAction))]
    [SubTypeDiscriminator("setAddressCustomType", typeof(commercetools.Sdk.Api.Models.Me.MyBusinessUnitSetAddressCustomTypeAction))]
    [SubTypeDiscriminator("setContactEmail", typeof(commercetools.Sdk.Api.Models.Me.MyBusinessUnitSetContactEmailAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.Me.MyBusinessUnitSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.Me.MyBusinessUnitSetCustomTypeAction))]
    [SubTypeDiscriminator("setDefaultBillingAddress", typeof(commercetools.Sdk.Api.Models.Me.MyBusinessUnitSetDefaultBillingAddressAction))]
    [SubTypeDiscriminator("setDefaultShippingAddress", typeof(commercetools.Sdk.Api.Models.Me.MyBusinessUnitSetDefaultShippingAddressAction))]
    public partial interface IMyBusinessUnitUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.Me.MyBusinessUnitAddAddressAction AddAddress(Action<commercetools.Sdk.Api.Models.Me.MyBusinessUnitAddAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyBusinessUnitAddAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyBusinessUnitAddBillingAddressIdAction AddBillingAddressId(Action<commercetools.Sdk.Api.Models.Me.MyBusinessUnitAddBillingAddressIdAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyBusinessUnitAddBillingAddressIdAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyBusinessUnitAddShippingAddressIdAction AddShippingAddressId(Action<commercetools.Sdk.Api.Models.Me.MyBusinessUnitAddShippingAddressIdAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyBusinessUnitAddShippingAddressIdAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyBusinessUnitChangeAddressAction ChangeAddress(Action<commercetools.Sdk.Api.Models.Me.MyBusinessUnitChangeAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyBusinessUnitChangeAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyBusinessUnitChangeAssociateAction ChangeAssociate(Action<commercetools.Sdk.Api.Models.Me.MyBusinessUnitChangeAssociateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyBusinessUnitChangeAssociateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyBusinessUnitChangeNameAction ChangeName(Action<commercetools.Sdk.Api.Models.Me.MyBusinessUnitChangeNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyBusinessUnitChangeNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyBusinessUnitChangeParentUnitAction ChangeParentUnit(Action<commercetools.Sdk.Api.Models.Me.MyBusinessUnitChangeParentUnitAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyBusinessUnitChangeParentUnitAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyBusinessUnitRemoveAddressAction RemoveAddress(Action<commercetools.Sdk.Api.Models.Me.MyBusinessUnitRemoveAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyBusinessUnitRemoveAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyBusinessUnitRemoveAssociateAction RemoveAssociate(Action<commercetools.Sdk.Api.Models.Me.MyBusinessUnitRemoveAssociateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyBusinessUnitRemoveAssociateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyBusinessUnitRemoveBillingAddressIdAction RemoveBillingAddressId(Action<commercetools.Sdk.Api.Models.Me.MyBusinessUnitRemoveBillingAddressIdAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyBusinessUnitRemoveBillingAddressIdAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyBusinessUnitRemoveShippingAddressIdAction RemoveShippingAddressId(Action<commercetools.Sdk.Api.Models.Me.MyBusinessUnitRemoveShippingAddressIdAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyBusinessUnitRemoveShippingAddressIdAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyBusinessUnitSetAddressCustomFieldAction SetAddressCustomField(Action<commercetools.Sdk.Api.Models.Me.MyBusinessUnitSetAddressCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyBusinessUnitSetAddressCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyBusinessUnitSetAddressCustomTypeAction SetAddressCustomType(Action<commercetools.Sdk.Api.Models.Me.MyBusinessUnitSetAddressCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyBusinessUnitSetAddressCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyBusinessUnitSetContactEmailAction SetContactEmail(Action<commercetools.Sdk.Api.Models.Me.MyBusinessUnitSetContactEmailAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyBusinessUnitSetContactEmailAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyBusinessUnitSetCustomFieldAction SetCustomField(Action<commercetools.Sdk.Api.Models.Me.MyBusinessUnitSetCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyBusinessUnitSetCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyBusinessUnitSetCustomTypeAction SetCustomType(Action<commercetools.Sdk.Api.Models.Me.MyBusinessUnitSetCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyBusinessUnitSetCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyBusinessUnitSetDefaultBillingAddressAction SetDefaultBillingAddress(Action<commercetools.Sdk.Api.Models.Me.MyBusinessUnitSetDefaultBillingAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyBusinessUnitSetDefaultBillingAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyBusinessUnitSetDefaultShippingAddressAction SetDefaultShippingAddress(Action<commercetools.Sdk.Api.Models.Me.MyBusinessUnitSetDefaultShippingAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyBusinessUnitSetDefaultShippingAddressAction();
            init?.Invoke(t);
            return t;
        }
    }
}
