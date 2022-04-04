using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.DiscountCodes
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeUpdateAction))]
    [SubTypeDiscriminator("changeCartDiscounts", typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeChangeCartDiscountsAction))]
    [SubTypeDiscriminator("changeGroups", typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeChangeGroupsAction))]
    [SubTypeDiscriminator("changeIsActive", typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeChangeIsActiveAction))]
    [SubTypeDiscriminator("setCartPredicate", typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetCartPredicateAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetCustomTypeAction))]
    [SubTypeDiscriminator("setDescription", typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetDescriptionAction))]
    [SubTypeDiscriminator("setMaxApplications", typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetMaxApplicationsAction))]
    [SubTypeDiscriminator("setMaxApplicationsPerCustomer", typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetMaxApplicationsPerCustomerAction))]
    [SubTypeDiscriminator("setName", typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetNameAction))]
    [SubTypeDiscriminator("setValidFrom", typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetValidFromAction))]
    [SubTypeDiscriminator("setValidFromAndUntil", typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetValidFromAndUntilAction))]
    [SubTypeDiscriminator("setValidUntil", typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetValidUntilAction))]
    public partial interface IDiscountCodeUpdateAction
    {
        string Action { get; set; }
    }
}
