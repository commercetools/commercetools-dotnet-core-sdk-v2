using commercetools.Api.Models.Me;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Me
{
    [JsonConverter(typeof(JsonSubtypes), "action")]
    [JsonSubtypes.KnownSubType(typeof(MyCustomerAddAddressAction), "addAddress")]
    [JsonSubtypes.KnownSubType(typeof(MyCustomerAddBillingAddressIdAction), "addBillingAddressId")]
    [JsonSubtypes.KnownSubType(typeof(MyCustomerAddShippingAddressIdAction), "addShippingAddressId")]
    [JsonSubtypes.KnownSubType(typeof(MyCustomerChangeAddressAction), "changeAddress")]
    [JsonSubtypes.KnownSubType(typeof(MyCustomerChangeEmailAction), "changeEmail")]
    [JsonSubtypes.KnownSubType(typeof(MyCustomerRemoveAddressAction), "removeAddress")]
    [JsonSubtypes.KnownSubType(typeof(MyCustomerRemoveBillingAddressIdAction), "removeBillingAddressId")]
    [JsonSubtypes.KnownSubType(typeof(MyCustomerRemoveShippingAddressIdAction), "removeShippingAddressId")]
    [JsonSubtypes.KnownSubType(typeof(MyCustomerSetCompanyNameAction), "setCompanyName")]
    [JsonSubtypes.KnownSubType(typeof(MyCustomerSetCustomFieldAction), "setCustomField")]
    [JsonSubtypes.KnownSubType(typeof(MyCustomerSetCustomTypeAction), "setCustomType")]
    [JsonSubtypes.KnownSubType(typeof(MyCustomerSetDateOfBirthAction), "setDateOfBirth")]
    [JsonSubtypes.KnownSubType(typeof(MyCustomerSetDefaultBillingAddressAction), "setDefaultBillingAddress")]
    [JsonSubtypes.KnownSubType(typeof(MyCustomerSetDefaultShippingAddressAction), "setDefaultShippingAddress")]
    [JsonSubtypes.KnownSubType(typeof(MyCustomerSetFirstNameAction), "setFirstName")]
    [JsonSubtypes.KnownSubType(typeof(MyCustomerSetLastNameAction), "setLastName")]
    [JsonSubtypes.KnownSubType(typeof(MyCustomerSetLocaleAction), "setLocale")]
    [JsonSubtypes.KnownSubType(typeof(MyCustomerSetMiddleNameAction), "setMiddleName")]
    [JsonSubtypes.KnownSubType(typeof(MyCustomerSetSalutationAction), "setSalutation")]
    [JsonSubtypes.KnownSubType(typeof(MyCustomerSetTitleAction), "setTitle")]
    [JsonSubtypes.KnownSubType(typeof(MyCustomerSetVatIdAction), "setVatId")]
    public abstract class MyCustomerUpdateAction 
    {
        public string Action { get; set;}
    }
}
