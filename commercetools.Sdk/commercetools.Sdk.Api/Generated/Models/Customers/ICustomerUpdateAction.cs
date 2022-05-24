using commercetools.Base.CustomAttributes;


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
    public partial interface ICustomerUpdateAction : commercetools.Sdk.Api.Models.IResourceUpdateAction<ICustomerUpdateAction>
    {
        new string Action { get; set; }
    }
}
