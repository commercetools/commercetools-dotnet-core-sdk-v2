using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Customers
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Customers.CustomerUpdateAction))]
    [SubTypeDiscriminator("addAddress", typeof(commercetools.Sdk.Api.Models.Customers.CustomerAddAddressAction))]
    [SubTypeDiscriminator("addBillingAddressId", typeof(commercetools.Sdk.Api.Models.Customers.CustomerAddBillingAddressIdAction))]
    [SubTypeDiscriminator("addShippingAddressId", typeof(commercetools.Sdk.Api.Models.Customers.CustomerAddShippingAddressIdAction))]
    [SubTypeDiscriminator("addStore", typeof(commercetools.Sdk.Api.Models.Customers.CustomerAddStoreAction))]
    [SubTypeDiscriminator("changeAddress", typeof(commercetools.Sdk.Api.Models.Customers.CustomerChangeAddressAction))]
    [SubTypeDiscriminator("changeEmail", typeof(commercetools.Sdk.Api.Models.Customers.CustomerChangeEmailAction))]
    [SubTypeDiscriminator("removeAddress", typeof(commercetools.Sdk.Api.Models.Customers.CustomerRemoveAddressAction))]
    [SubTypeDiscriminator("removeBillingAddressId", typeof(commercetools.Sdk.Api.Models.Customers.CustomerRemoveBillingAddressIdAction))]
    [SubTypeDiscriminator("removeShippingAddressId", typeof(commercetools.Sdk.Api.Models.Customers.CustomerRemoveShippingAddressIdAction))]
    [SubTypeDiscriminator("removeStore", typeof(commercetools.Sdk.Api.Models.Customers.CustomerRemoveStoreAction))]
    [SubTypeDiscriminator("setAddressCustomField", typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetAddressCustomFieldAction))]
    [SubTypeDiscriminator("setAddressCustomType", typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetAddressCustomTypeAction))]
    [SubTypeDiscriminator("setAuthenticationMode", typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetAuthenticationModeAction))]
    [SubTypeDiscriminator("setCompanyName", typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetCompanyNameAction))]
    [SubTypeDiscriminator("setCustomerGroup", typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetCustomerGroupAction))]
    [SubTypeDiscriminator("setCustomerNumber", typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetCustomerNumberAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetCustomTypeAction))]
    [SubTypeDiscriminator("setDateOfBirth", typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetDateOfBirthAction))]
    [SubTypeDiscriminator("setDefaultBillingAddress", typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetDefaultBillingAddressAction))]
    [SubTypeDiscriminator("setDefaultShippingAddress", typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetDefaultShippingAddressAction))]
    [SubTypeDiscriminator("setExternalId", typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetExternalIdAction))]
    [SubTypeDiscriminator("setFirstName", typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetFirstNameAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetKeyAction))]
    [SubTypeDiscriminator("setLastName", typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetLastNameAction))]
    [SubTypeDiscriminator("setLocale", typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetLocaleAction))]
    [SubTypeDiscriminator("setMiddleName", typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetMiddleNameAction))]
    [SubTypeDiscriminator("setSalutation", typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetSalutationAction))]
    [SubTypeDiscriminator("setStores", typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetStoresAction))]
    [SubTypeDiscriminator("setTitle", typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetTitleAction))]
    [SubTypeDiscriminator("setVatId", typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetVatIdAction))]
    public partial interface ICustomerUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.Customers.CustomerAddAddressAction AddAddress(Action<commercetools.Sdk.Api.Models.Customers.CustomerAddAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Customers.CustomerAddAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Customers.CustomerAddBillingAddressIdAction AddBillingAddressId(Action<commercetools.Sdk.Api.Models.Customers.CustomerAddBillingAddressIdAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Customers.CustomerAddBillingAddressIdAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Customers.CustomerAddShippingAddressIdAction AddShippingAddressId(Action<commercetools.Sdk.Api.Models.Customers.CustomerAddShippingAddressIdAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Customers.CustomerAddShippingAddressIdAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Customers.CustomerAddStoreAction AddStore(Action<commercetools.Sdk.Api.Models.Customers.CustomerAddStoreAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Customers.CustomerAddStoreAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Customers.CustomerChangeAddressAction ChangeAddress(Action<commercetools.Sdk.Api.Models.Customers.CustomerChangeAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Customers.CustomerChangeAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Customers.CustomerChangeEmailAction ChangeEmail(Action<commercetools.Sdk.Api.Models.Customers.CustomerChangeEmailAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Customers.CustomerChangeEmailAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Customers.CustomerRemoveAddressAction RemoveAddress(Action<commercetools.Sdk.Api.Models.Customers.CustomerRemoveAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Customers.CustomerRemoveAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Customers.CustomerRemoveBillingAddressIdAction RemoveBillingAddressId(Action<commercetools.Sdk.Api.Models.Customers.CustomerRemoveBillingAddressIdAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Customers.CustomerRemoveBillingAddressIdAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Customers.CustomerRemoveShippingAddressIdAction RemoveShippingAddressId(Action<commercetools.Sdk.Api.Models.Customers.CustomerRemoveShippingAddressIdAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Customers.CustomerRemoveShippingAddressIdAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Customers.CustomerRemoveStoreAction RemoveStore(Action<commercetools.Sdk.Api.Models.Customers.CustomerRemoveStoreAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Customers.CustomerRemoveStoreAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Customers.CustomerSetAddressCustomFieldAction SetAddressCustomField(Action<commercetools.Sdk.Api.Models.Customers.CustomerSetAddressCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Customers.CustomerSetAddressCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Customers.CustomerSetAddressCustomTypeAction SetAddressCustomType(Action<commercetools.Sdk.Api.Models.Customers.CustomerSetAddressCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Customers.CustomerSetAddressCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Customers.CustomerSetAuthenticationModeAction SetAuthenticationMode(Action<commercetools.Sdk.Api.Models.Customers.CustomerSetAuthenticationModeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Customers.CustomerSetAuthenticationModeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Customers.CustomerSetCompanyNameAction SetCompanyName(Action<commercetools.Sdk.Api.Models.Customers.CustomerSetCompanyNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Customers.CustomerSetCompanyNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Customers.CustomerSetCustomerGroupAction SetCustomerGroup(Action<commercetools.Sdk.Api.Models.Customers.CustomerSetCustomerGroupAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Customers.CustomerSetCustomerGroupAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Customers.CustomerSetCustomerNumberAction SetCustomerNumber(Action<commercetools.Sdk.Api.Models.Customers.CustomerSetCustomerNumberAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Customers.CustomerSetCustomerNumberAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Customers.CustomerSetCustomFieldAction SetCustomField(Action<commercetools.Sdk.Api.Models.Customers.CustomerSetCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Customers.CustomerSetCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Customers.CustomerSetCustomTypeAction SetCustomType(Action<commercetools.Sdk.Api.Models.Customers.CustomerSetCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Customers.CustomerSetCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Customers.CustomerSetDateOfBirthAction SetDateOfBirth(Action<commercetools.Sdk.Api.Models.Customers.CustomerSetDateOfBirthAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Customers.CustomerSetDateOfBirthAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Customers.CustomerSetDefaultBillingAddressAction SetDefaultBillingAddress(Action<commercetools.Sdk.Api.Models.Customers.CustomerSetDefaultBillingAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Customers.CustomerSetDefaultBillingAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Customers.CustomerSetDefaultShippingAddressAction SetDefaultShippingAddress(Action<commercetools.Sdk.Api.Models.Customers.CustomerSetDefaultShippingAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Customers.CustomerSetDefaultShippingAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Customers.CustomerSetExternalIdAction SetExternalId(Action<commercetools.Sdk.Api.Models.Customers.CustomerSetExternalIdAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Customers.CustomerSetExternalIdAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Customers.CustomerSetFirstNameAction SetFirstName(Action<commercetools.Sdk.Api.Models.Customers.CustomerSetFirstNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Customers.CustomerSetFirstNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Customers.CustomerSetKeyAction SetKey(Action<commercetools.Sdk.Api.Models.Customers.CustomerSetKeyAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Customers.CustomerSetKeyAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Customers.CustomerSetLastNameAction SetLastName(Action<commercetools.Sdk.Api.Models.Customers.CustomerSetLastNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Customers.CustomerSetLastNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Customers.CustomerSetLocaleAction SetLocale(Action<commercetools.Sdk.Api.Models.Customers.CustomerSetLocaleAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Customers.CustomerSetLocaleAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Customers.CustomerSetMiddleNameAction SetMiddleName(Action<commercetools.Sdk.Api.Models.Customers.CustomerSetMiddleNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Customers.CustomerSetMiddleNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Customers.CustomerSetSalutationAction SetSalutation(Action<commercetools.Sdk.Api.Models.Customers.CustomerSetSalutationAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Customers.CustomerSetSalutationAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Customers.CustomerSetStoresAction SetStores(Action<commercetools.Sdk.Api.Models.Customers.CustomerSetStoresAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Customers.CustomerSetStoresAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Customers.CustomerSetTitleAction SetTitle(Action<commercetools.Sdk.Api.Models.Customers.CustomerSetTitleAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Customers.CustomerSetTitleAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Customers.CustomerSetVatIdAction SetVatId(Action<commercetools.Sdk.Api.Models.Customers.CustomerSetVatIdAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Customers.CustomerSetVatIdAction();
            init?.Invoke(t);
            return t;
        }
    }
}
