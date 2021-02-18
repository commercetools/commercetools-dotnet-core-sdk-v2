using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [TypeDiscriminator(nameof(Action))]
    [SubTypeDiscriminator("addAddress", typeof(commercetools.Api.Models.Customers.CustomerAddAddressAction))]
    [SubTypeDiscriminator("addBillingAddressId", typeof(commercetools.Api.Models.Customers.CustomerAddBillingAddressIdAction))]
    [SubTypeDiscriminator("addShippingAddressId", typeof(commercetools.Api.Models.Customers.CustomerAddShippingAddressIdAction))]
    [SubTypeDiscriminator("addStore", typeof(commercetools.Api.Models.Customers.CustomerAddStoreAction))]
    [SubTypeDiscriminator("changeAddress", typeof(commercetools.Api.Models.Customers.CustomerChangeAddressAction))]
    [SubTypeDiscriminator("changeEmail", typeof(commercetools.Api.Models.Customers.CustomerChangeEmailAction))]
    [SubTypeDiscriminator("removeAddress", typeof(commercetools.Api.Models.Customers.CustomerRemoveAddressAction))]
    [SubTypeDiscriminator("removeBillingAddressId", typeof(commercetools.Api.Models.Customers.CustomerRemoveBillingAddressIdAction))]
    [SubTypeDiscriminator("removeShippingAddressId", typeof(commercetools.Api.Models.Customers.CustomerRemoveShippingAddressIdAction))]
    [SubTypeDiscriminator("removeStore", typeof(commercetools.Api.Models.Customers.CustomerRemoveStoreAction))]
    [SubTypeDiscriminator("setAddressCustomField", typeof(commercetools.Api.Models.Customers.CustomerSetAddressCustomFieldAction))]
    [SubTypeDiscriminator("setAddressCustomType", typeof(commercetools.Api.Models.Customers.CustomerSetAddressCustomTypeAction))]
    [SubTypeDiscriminator("setCompanyName", typeof(commercetools.Api.Models.Customers.CustomerSetCompanyNameAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Api.Models.Customers.CustomerSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Api.Models.Customers.CustomerSetCustomTypeAction))]
    [SubTypeDiscriminator("setCustomerGroup", typeof(commercetools.Api.Models.Customers.CustomerSetCustomerGroupAction))]
    [SubTypeDiscriminator("setCustomerNumber", typeof(commercetools.Api.Models.Customers.CustomerSetCustomerNumberAction))]
    [SubTypeDiscriminator("setDateOfBirth", typeof(commercetools.Api.Models.Customers.CustomerSetDateOfBirthAction))]
    [SubTypeDiscriminator("setDefaultBillingAddress", typeof(commercetools.Api.Models.Customers.CustomerSetDefaultBillingAddressAction))]
    [SubTypeDiscriminator("setDefaultShippingAddress", typeof(commercetools.Api.Models.Customers.CustomerSetDefaultShippingAddressAction))]
    [SubTypeDiscriminator("setExternalId", typeof(commercetools.Api.Models.Customers.CustomerSetExternalIdAction))]
    [SubTypeDiscriminator("setFirstName", typeof(commercetools.Api.Models.Customers.CustomerSetFirstNameAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Api.Models.Customers.CustomerSetKeyAction))]
    [SubTypeDiscriminator("setLastName", typeof(commercetools.Api.Models.Customers.CustomerSetLastNameAction))]
    [SubTypeDiscriminator("setLocale", typeof(commercetools.Api.Models.Customers.CustomerSetLocaleAction))]
    [SubTypeDiscriminator("setMiddleName", typeof(commercetools.Api.Models.Customers.CustomerSetMiddleNameAction))]
    [SubTypeDiscriminator("setSalutation", typeof(commercetools.Api.Models.Customers.CustomerSetSalutationAction))]
    [SubTypeDiscriminator("setStores", typeof(commercetools.Api.Models.Customers.CustomerSetStoresAction))]
    [SubTypeDiscriminator("setTitle", typeof(commercetools.Api.Models.Customers.CustomerSetTitleAction))]
    [SubTypeDiscriminator("setVatId", typeof(commercetools.Api.Models.Customers.CustomerSetVatIdAction))]
    public partial interface ICustomerUpdateAction 
    {
        string Action { get; set;}
    }
}
