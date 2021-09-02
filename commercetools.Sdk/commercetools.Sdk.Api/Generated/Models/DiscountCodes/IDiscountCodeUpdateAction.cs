using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.DiscountCodes.DiscountCodeUpdateAction))]
    [SubTypeDiscriminator("changeCartDiscounts", typeof(commercetools.Api.Models.DiscountCodes.DiscountCodeChangeCartDiscountsAction))]
    [SubTypeDiscriminator("changeGroups", typeof(commercetools.Api.Models.DiscountCodes.DiscountCodeChangeGroupsAction))]
    [SubTypeDiscriminator("changeIsActive", typeof(commercetools.Api.Models.DiscountCodes.DiscountCodeChangeIsActiveAction))]
    [SubTypeDiscriminator("setCartPredicate", typeof(commercetools.Api.Models.DiscountCodes.DiscountCodeSetCartPredicateAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Api.Models.DiscountCodes.DiscountCodeSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Api.Models.DiscountCodes.DiscountCodeSetCustomTypeAction))]
    [SubTypeDiscriminator("setDescription", typeof(commercetools.Api.Models.DiscountCodes.DiscountCodeSetDescriptionAction))]
    [SubTypeDiscriminator("setMaxApplications", typeof(commercetools.Api.Models.DiscountCodes.DiscountCodeSetMaxApplicationsAction))]
    [SubTypeDiscriminator("setMaxApplicationsPerCustomer", typeof(commercetools.Api.Models.DiscountCodes.DiscountCodeSetMaxApplicationsPerCustomerAction))]
    [SubTypeDiscriminator("setName", typeof(commercetools.Api.Models.DiscountCodes.DiscountCodeSetNameAction))]
    [SubTypeDiscriminator("setValidFrom", typeof(commercetools.Api.Models.DiscountCodes.DiscountCodeSetValidFromAction))]
    [SubTypeDiscriminator("setValidFromAndUntil", typeof(commercetools.Api.Models.DiscountCodes.DiscountCodeSetValidFromAndUntilAction))]
    [SubTypeDiscriminator("setValidUntil", typeof(commercetools.Api.Models.DiscountCodes.DiscountCodeSetValidUntilAction))]
    public partial interface IDiscountCodeUpdateAction
    {
        string Action { get; set; }
    }
}
