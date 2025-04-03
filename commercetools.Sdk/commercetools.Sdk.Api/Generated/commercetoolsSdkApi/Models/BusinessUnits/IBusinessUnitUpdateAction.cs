using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitUpdateAction))]
    [SubTypeDiscriminator("addAddress", typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitAddAddressAction))]
    [SubTypeDiscriminator("addAssociate", typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitAddAssociateAction))]
    [SubTypeDiscriminator("addBillingAddressId", typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitAddBillingAddressIdAction))]
    [SubTypeDiscriminator("addShippingAddressId", typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitAddShippingAddressIdAction))]
    [SubTypeDiscriminator("addStore", typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitAddStoreAction))]
    [SubTypeDiscriminator("changeAddress", typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitChangeAddressAction))]
    [SubTypeDiscriminator("changeApprovalRuleMode", typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitChangeApprovalRuleModeAction))]
    [SubTypeDiscriminator("changeAssociate", typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitChangeAssociateAction))]
    [SubTypeDiscriminator("changeAssociateMode", typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitChangeAssociateModeAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitChangeNameAction))]
    [SubTypeDiscriminator("changeParentUnit", typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitChangeParentUnitAction))]
    [SubTypeDiscriminator("changeStatus", typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitChangeStatusAction))]
    [SubTypeDiscriminator("removeAddress", typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitRemoveAddressAction))]
    [SubTypeDiscriminator("removeAssociate", typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitRemoveAssociateAction))]
    [SubTypeDiscriminator("removeBillingAddressId", typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitRemoveBillingAddressIdAction))]
    [SubTypeDiscriminator("removeShippingAddressId", typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitRemoveShippingAddressIdAction))]
    [SubTypeDiscriminator("removeStore", typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitRemoveStoreAction))]
    [SubTypeDiscriminator("setAddressCustomField", typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetAddressCustomFieldAction))]
    [SubTypeDiscriminator("setAddressCustomType", typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetAddressCustomTypeAction))]
    [SubTypeDiscriminator("setAssociates", typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetAssociatesAction))]
    [SubTypeDiscriminator("setContactEmail", typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetContactEmailAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetCustomTypeAction))]
    [SubTypeDiscriminator("setDefaultBillingAddress", typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetDefaultBillingAddressAction))]
    [SubTypeDiscriminator("setDefaultShippingAddress", typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetDefaultShippingAddressAction))]
    [SubTypeDiscriminator("setStoreMode", typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetStoreModeAction))]
    [SubTypeDiscriminator("setStores", typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetStoresAction))]
    [SubTypeDiscriminator("setUnitType", typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetUnitTypeAction))]
    public partial interface IBusinessUnitUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitAddAddressAction AddAddress(Action<commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitAddAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitAddAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitAddAssociateAction AddAssociate(Action<commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitAddAssociateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitAddAssociateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitAddBillingAddressIdAction AddBillingAddressId(Action<commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitAddBillingAddressIdAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitAddBillingAddressIdAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitAddShippingAddressIdAction AddShippingAddressId(Action<commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitAddShippingAddressIdAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitAddShippingAddressIdAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitAddStoreAction AddStore(Action<commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitAddStoreAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitAddStoreAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitChangeAddressAction ChangeAddress(Action<commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitChangeAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitChangeAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitChangeApprovalRuleModeAction ChangeApprovalRuleMode(Action<commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitChangeApprovalRuleModeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitChangeApprovalRuleModeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitChangeAssociateAction ChangeAssociate(Action<commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitChangeAssociateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitChangeAssociateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitChangeAssociateModeAction ChangeAssociateMode(Action<commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitChangeAssociateModeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitChangeAssociateModeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitChangeNameAction ChangeName(Action<commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitChangeNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitChangeNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitChangeParentUnitAction ChangeParentUnit(Action<commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitChangeParentUnitAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitChangeParentUnitAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitChangeStatusAction ChangeStatus(Action<commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitChangeStatusAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitChangeStatusAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitRemoveAddressAction RemoveAddress(Action<commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitRemoveAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitRemoveAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitRemoveAssociateAction RemoveAssociate(Action<commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitRemoveAssociateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitRemoveAssociateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitRemoveBillingAddressIdAction RemoveBillingAddressId(Action<commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitRemoveBillingAddressIdAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitRemoveBillingAddressIdAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitRemoveShippingAddressIdAction RemoveShippingAddressId(Action<commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitRemoveShippingAddressIdAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitRemoveShippingAddressIdAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitRemoveStoreAction RemoveStore(Action<commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitRemoveStoreAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitRemoveStoreAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetAddressCustomFieldAction SetAddressCustomField(Action<commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetAddressCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetAddressCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetAddressCustomTypeAction SetAddressCustomType(Action<commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetAddressCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetAddressCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetAssociatesAction SetAssociates(Action<commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetAssociatesAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetAssociatesAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetContactEmailAction SetContactEmail(Action<commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetContactEmailAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetContactEmailAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetCustomFieldAction SetCustomField(Action<commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetCustomTypeAction SetCustomType(Action<commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetDefaultBillingAddressAction SetDefaultBillingAddress(Action<commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetDefaultBillingAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetDefaultBillingAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetDefaultShippingAddressAction SetDefaultShippingAddress(Action<commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetDefaultShippingAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetDefaultShippingAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetStoreModeAction SetStoreMode(Action<commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetStoreModeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetStoreModeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetStoresAction SetStores(Action<commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetStoresAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetStoresAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetUnitTypeAction SetUnitType(Action<commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetUnitTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetUnitTypeAction();
            init?.Invoke(t);
            return t;
        }
    }
}
