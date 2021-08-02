using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountUpdateAction))]
    [SubTypeDiscriminator("changeIsActive", typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountChangeIsActiveAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountChangeNameAction))]
    [SubTypeDiscriminator("changePredicate", typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountChangePredicateAction))]
    [SubTypeDiscriminator("changeSortOrder", typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountChangeSortOrderAction))]
    [SubTypeDiscriminator("changeValue", typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountChangeValueAction))]
    [SubTypeDiscriminator("setDescription", typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountSetDescriptionAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountSetKeyAction))]
    [SubTypeDiscriminator("setValidFrom", typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountSetValidFromAction))]
    [SubTypeDiscriminator("setValidFromAndUntil", typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountSetValidFromAndUntilAction))]
    [SubTypeDiscriminator("setValidUntil", typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountSetValidUntilAction))]
    public partial interface IProductDiscountUpdateAction 
    {
        string Action { get; set;}
    }
}
