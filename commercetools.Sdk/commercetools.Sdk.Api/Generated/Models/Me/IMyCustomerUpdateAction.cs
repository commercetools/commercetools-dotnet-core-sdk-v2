using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.Me.MyCustomerUpdateAction))]
    [SubTypeDiscriminator("addAddress", typeof(commercetools.Api.Models.Me.MyCustomerAddAddressAction))]
    [SubTypeDiscriminator("addBillingAddressId", typeof(commercetools.Api.Models.Me.MyCustomerAddBillingAddressIdAction))]
    [SubTypeDiscriminator("addShippingAddressId", typeof(commercetools.Api.Models.Me.MyCustomerAddShippingAddressIdAction))]
    [SubTypeDiscriminator("changeAddress", typeof(commercetools.Api.Models.Me.MyCustomerChangeAddressAction))]
    [SubTypeDiscriminator("changeEmail", typeof(commercetools.Api.Models.Me.MyCustomerChangeEmailAction))]
    [SubTypeDiscriminator("removeAddress", typeof(commercetools.Api.Models.Me.MyCustomerRemoveAddressAction))]
    [SubTypeDiscriminator("removeBillingAddressId", typeof(commercetools.Api.Models.Me.MyCustomerRemoveBillingAddressIdAction))]
    [SubTypeDiscriminator("removeShippingAddressId", typeof(commercetools.Api.Models.Me.MyCustomerRemoveShippingAddressIdAction))]
    [SubTypeDiscriminator("setCompanyName", typeof(commercetools.Api.Models.Me.MyCustomerSetCompanyNameAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Api.Models.Me.MyCustomerSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Api.Models.Me.MyCustomerSetCustomTypeAction))]
    [SubTypeDiscriminator("setDateOfBirth", typeof(commercetools.Api.Models.Me.MyCustomerSetDateOfBirthAction))]
    [SubTypeDiscriminator("setDefaultBillingAddress", typeof(commercetools.Api.Models.Me.MyCustomerSetDefaultBillingAddressAction))]
    [SubTypeDiscriminator("setDefaultShippingAddress", typeof(commercetools.Api.Models.Me.MyCustomerSetDefaultShippingAddressAction))]
    [SubTypeDiscriminator("setFirstName", typeof(commercetools.Api.Models.Me.MyCustomerSetFirstNameAction))]
    [SubTypeDiscriminator("setLastName", typeof(commercetools.Api.Models.Me.MyCustomerSetLastNameAction))]
    [SubTypeDiscriminator("setLocale", typeof(commercetools.Api.Models.Me.MyCustomerSetLocaleAction))]
    [SubTypeDiscriminator("setMiddleName", typeof(commercetools.Api.Models.Me.MyCustomerSetMiddleNameAction))]
    [SubTypeDiscriminator("setSalutation", typeof(commercetools.Api.Models.Me.MyCustomerSetSalutationAction))]
    [SubTypeDiscriminator("setTitle", typeof(commercetools.Api.Models.Me.MyCustomerSetTitleAction))]
    [SubTypeDiscriminator("setVatId", typeof(commercetools.Api.Models.Me.MyCustomerSetVatIdAction))]
    public partial interface IMyCustomerUpdateAction 
    {
        string Action { get; set;}
    }
}
