using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.DiscountGroups
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.DiscountGroups.DiscountGroupUpdateAction))]
    [SubTypeDiscriminator("setDescription", typeof(commercetools.Sdk.Api.Models.DiscountGroups.DiscountGroupSetDescriptionAction))]
    [SubTypeDiscriminator("setIsActive", typeof(commercetools.Sdk.Api.Models.DiscountGroups.DiscountGroupSetIsActiveAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Sdk.Api.Models.DiscountGroups.DiscountGroupSetKeyAction))]
    [SubTypeDiscriminator("setName", typeof(commercetools.Sdk.Api.Models.DiscountGroups.DiscountGroupSetNameAction))]
    [SubTypeDiscriminator("setSortOrder", typeof(commercetools.Sdk.Api.Models.DiscountGroups.DiscountGroupSetSortOrderAction))]
    public partial interface IDiscountGroupUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.DiscountGroups.DiscountGroupSetDescriptionAction SetDescription(Action<commercetools.Sdk.Api.Models.DiscountGroups.DiscountGroupSetDescriptionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.DiscountGroups.DiscountGroupSetDescriptionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.DiscountGroups.DiscountGroupSetIsActiveAction SetIsActive(Action<commercetools.Sdk.Api.Models.DiscountGroups.DiscountGroupSetIsActiveAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.DiscountGroups.DiscountGroupSetIsActiveAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.DiscountGroups.DiscountGroupSetKeyAction SetKey(Action<commercetools.Sdk.Api.Models.DiscountGroups.DiscountGroupSetKeyAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.DiscountGroups.DiscountGroupSetKeyAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.DiscountGroups.DiscountGroupSetNameAction SetName(Action<commercetools.Sdk.Api.Models.DiscountGroups.DiscountGroupSetNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.DiscountGroups.DiscountGroupSetNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.DiscountGroups.DiscountGroupSetSortOrderAction SetSortOrder(Action<commercetools.Sdk.Api.Models.DiscountGroups.DiscountGroupSetSortOrderAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.DiscountGroups.DiscountGroupSetSortOrderAction();
            init?.Invoke(t);
            return t;
        }
    }
}
