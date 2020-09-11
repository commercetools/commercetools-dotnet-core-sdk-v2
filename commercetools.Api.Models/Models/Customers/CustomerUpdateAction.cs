using commercetools.Api.Models.Customers;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Customers
{
    [JsonConverter(typeof(JsonSubtypes), "action")]
    [JsonSubtypes.KnownSubType(typeof(CustomerAddAddressAction), "addAddress")]
    [JsonSubtypes.KnownSubType(typeof(CustomerAddBillingAddressIdAction), "addBillingAddressId")]
    [JsonSubtypes.KnownSubType(typeof(CustomerAddShippingAddressIdAction), "addShippingAddressId")]
    [JsonSubtypes.KnownSubType(typeof(CustomerAddStoreAction), "addStore")]
    [JsonSubtypes.KnownSubType(typeof(CustomerChangeAddressAction), "changeAddress")]
    [JsonSubtypes.KnownSubType(typeof(CustomerChangeEmailAction), "changeEmail")]
    [JsonSubtypes.KnownSubType(typeof(CustomerRemoveAddressAction), "removeAddress")]
    [JsonSubtypes.KnownSubType(typeof(CustomerRemoveBillingAddressIdAction), "removeBillingAddressId")]
    [JsonSubtypes.KnownSubType(typeof(CustomerRemoveShippingAddressIdAction), "removeShippingAddressId")]
    [JsonSubtypes.KnownSubType(typeof(CustomerRemoveStoreAction), "removeStore")]
    [JsonSubtypes.KnownSubType(typeof(CustomerSetCompanyNameAction), "setCompanyName")]
    [JsonSubtypes.KnownSubType(typeof(CustomerSetCustomFieldAction), "setCustomField")]
    [JsonSubtypes.KnownSubType(typeof(CustomerSetCustomTypeAction), "setCustomType")]
    [JsonSubtypes.KnownSubType(typeof(CustomerSetCustomerGroupAction), "setCustomerGroup")]
    [JsonSubtypes.KnownSubType(typeof(CustomerSetCustomerNumberAction), "setCustomerNumber")]
    [JsonSubtypes.KnownSubType(typeof(CustomerSetDateOfBirthAction), "setDateOfBirth")]
    [JsonSubtypes.KnownSubType(typeof(CustomerSetDefaultBillingAddressAction), "setDefaultBillingAddress")]
    [JsonSubtypes.KnownSubType(typeof(CustomerSetDefaultShippingAddressAction), "setDefaultShippingAddress")]
    [JsonSubtypes.KnownSubType(typeof(CustomerSetExternalIdAction), "setExternalId")]
    [JsonSubtypes.KnownSubType(typeof(CustomerSetFirstNameAction), "setFirstName")]
    [JsonSubtypes.KnownSubType(typeof(CustomerSetKeyAction), "setKey")]
    [JsonSubtypes.KnownSubType(typeof(CustomerSetLastNameAction), "setLastName")]
    [JsonSubtypes.KnownSubType(typeof(CustomerSetLocaleAction), "setLocale")]
    [JsonSubtypes.KnownSubType(typeof(CustomerSetMiddleNameAction), "setMiddleName")]
    [JsonSubtypes.KnownSubType(typeof(CustomerSetSalutationAction), "setSalutation")]
    [JsonSubtypes.KnownSubType(typeof(CustomerSetStoresAction), "setStores")]
    [JsonSubtypes.KnownSubType(typeof(CustomerSetTitleAction), "setTitle")]
    [JsonSubtypes.KnownSubType(typeof(CustomerSetVatIdAction), "setVatId")]
    public abstract class CustomerUpdateAction 
    {
        public string Action { get; set;}
    }
}
