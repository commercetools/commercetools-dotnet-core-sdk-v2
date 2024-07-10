using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Me.MyCustomerUpdateAction))]
    [SubTypeDiscriminator("addAddress", typeof(commercetools.Sdk.Api.Models.Me.MyCustomerAddAddressAction))]
    [SubTypeDiscriminator("addBillingAddressId", typeof(commercetools.Sdk.Api.Models.Me.MyCustomerAddBillingAddressIdAction))]
    [SubTypeDiscriminator("addShippingAddressId", typeof(commercetools.Sdk.Api.Models.Me.MyCustomerAddShippingAddressIdAction))]
    [SubTypeDiscriminator("changeAddress", typeof(commercetools.Sdk.Api.Models.Me.MyCustomerChangeAddressAction))]
    [SubTypeDiscriminator("changeEmail", typeof(commercetools.Sdk.Api.Models.Me.MyCustomerChangeEmailAction))]
    [SubTypeDiscriminator("removeAddress", typeof(commercetools.Sdk.Api.Models.Me.MyCustomerRemoveAddressAction))]
    [SubTypeDiscriminator("removeBillingAddressId", typeof(commercetools.Sdk.Api.Models.Me.MyCustomerRemoveBillingAddressIdAction))]
    [SubTypeDiscriminator("removeShippingAddressId", typeof(commercetools.Sdk.Api.Models.Me.MyCustomerRemoveShippingAddressIdAction))]
    [SubTypeDiscriminator("setCompanyName", typeof(commercetools.Sdk.Api.Models.Me.MyCustomerSetCompanyNameAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.Me.MyCustomerSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.Me.MyCustomerSetCustomTypeAction))]
    [SubTypeDiscriminator("setDateOfBirth", typeof(commercetools.Sdk.Api.Models.Me.MyCustomerSetDateOfBirthAction))]
    [SubTypeDiscriminator("setDefaultBillingAddress", typeof(commercetools.Sdk.Api.Models.Me.MyCustomerSetDefaultBillingAddressAction))]
    [SubTypeDiscriminator("setDefaultShippingAddress", typeof(commercetools.Sdk.Api.Models.Me.MyCustomerSetDefaultShippingAddressAction))]
    [SubTypeDiscriminator("setFirstName", typeof(commercetools.Sdk.Api.Models.Me.MyCustomerSetFirstNameAction))]
    [SubTypeDiscriminator("setLastName", typeof(commercetools.Sdk.Api.Models.Me.MyCustomerSetLastNameAction))]
    [SubTypeDiscriminator("setLocale", typeof(commercetools.Sdk.Api.Models.Me.MyCustomerSetLocaleAction))]
    [SubTypeDiscriminator("setMiddleName", typeof(commercetools.Sdk.Api.Models.Me.MyCustomerSetMiddleNameAction))]
    [SubTypeDiscriminator("setSalutation", typeof(commercetools.Sdk.Api.Models.Me.MyCustomerSetSalutationAction))]
    [SubTypeDiscriminator("setTitle", typeof(commercetools.Sdk.Api.Models.Me.MyCustomerSetTitleAction))]
    [SubTypeDiscriminator("setVatId", typeof(commercetools.Sdk.Api.Models.Me.MyCustomerSetVatIdAction))]
    public partial interface IMyCustomerUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.Me.MyCustomerAddAddressAction AddAddress(Action<commercetools.Sdk.Api.Models.Me.MyCustomerAddAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCustomerAddAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCustomerAddBillingAddressIdAction AddBillingAddressId(Action<commercetools.Sdk.Api.Models.Me.MyCustomerAddBillingAddressIdAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCustomerAddBillingAddressIdAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCustomerAddShippingAddressIdAction AddShippingAddressId(Action<commercetools.Sdk.Api.Models.Me.MyCustomerAddShippingAddressIdAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCustomerAddShippingAddressIdAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCustomerChangeAddressAction ChangeAddress(Action<commercetools.Sdk.Api.Models.Me.MyCustomerChangeAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCustomerChangeAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCustomerChangeEmailAction ChangeEmail(Action<commercetools.Sdk.Api.Models.Me.MyCustomerChangeEmailAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCustomerChangeEmailAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCustomerRemoveAddressAction RemoveAddress(Action<commercetools.Sdk.Api.Models.Me.MyCustomerRemoveAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCustomerRemoveAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCustomerRemoveBillingAddressIdAction RemoveBillingAddressId(Action<commercetools.Sdk.Api.Models.Me.MyCustomerRemoveBillingAddressIdAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCustomerRemoveBillingAddressIdAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCustomerRemoveShippingAddressIdAction RemoveShippingAddressId(Action<commercetools.Sdk.Api.Models.Me.MyCustomerRemoveShippingAddressIdAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCustomerRemoveShippingAddressIdAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCustomerSetCompanyNameAction SetCompanyName(Action<commercetools.Sdk.Api.Models.Me.MyCustomerSetCompanyNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCustomerSetCompanyNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCustomerSetCustomFieldAction SetCustomField(Action<commercetools.Sdk.Api.Models.Me.MyCustomerSetCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCustomerSetCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCustomerSetCustomTypeAction SetCustomType(Action<commercetools.Sdk.Api.Models.Me.MyCustomerSetCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCustomerSetCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCustomerSetDateOfBirthAction SetDateOfBirth(Action<commercetools.Sdk.Api.Models.Me.MyCustomerSetDateOfBirthAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCustomerSetDateOfBirthAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCustomerSetDefaultBillingAddressAction SetDefaultBillingAddress(Action<commercetools.Sdk.Api.Models.Me.MyCustomerSetDefaultBillingAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCustomerSetDefaultBillingAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCustomerSetDefaultShippingAddressAction SetDefaultShippingAddress(Action<commercetools.Sdk.Api.Models.Me.MyCustomerSetDefaultShippingAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCustomerSetDefaultShippingAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCustomerSetFirstNameAction SetFirstName(Action<commercetools.Sdk.Api.Models.Me.MyCustomerSetFirstNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCustomerSetFirstNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCustomerSetLastNameAction SetLastName(Action<commercetools.Sdk.Api.Models.Me.MyCustomerSetLastNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCustomerSetLastNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCustomerSetLocaleAction SetLocale(Action<commercetools.Sdk.Api.Models.Me.MyCustomerSetLocaleAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCustomerSetLocaleAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCustomerSetMiddleNameAction SetMiddleName(Action<commercetools.Sdk.Api.Models.Me.MyCustomerSetMiddleNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCustomerSetMiddleNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCustomerSetSalutationAction SetSalutation(Action<commercetools.Sdk.Api.Models.Me.MyCustomerSetSalutationAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCustomerSetSalutationAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCustomerSetTitleAction SetTitle(Action<commercetools.Sdk.Api.Models.Me.MyCustomerSetTitleAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCustomerSetTitleAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCustomerSetVatIdAction SetVatId(Action<commercetools.Sdk.Api.Models.Me.MyCustomerSetVatIdAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCustomerSetVatIdAction();
            init?.Invoke(t);
            return t;
        }
    }
}
