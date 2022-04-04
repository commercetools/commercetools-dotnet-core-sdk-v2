using commercetools.Base.CustomAttributes;


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
    }
}
