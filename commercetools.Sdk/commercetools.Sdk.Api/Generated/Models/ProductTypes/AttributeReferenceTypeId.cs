using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.Api.Models.ProductTypes
{
    public enum AttributeReferenceTypeId
    {
        [Description("cart")]
        Cart,

        [Description("category")]
        Category,

        [Description("channel")]
        Channel,

        [Description("customer")]
        Customer,

        [Description("key-value-document")]
        KeyValueDocument,

        [Description("order")]
        Order,

        [Description("product")]
        Product,

        [Description("product-type")]
        ProductType,

        [Description("review")]
        Review,

        [Description("shipping-method")]
        ShippingMethod,

        [Description("state")]
        State,

        [Description("zone")]
        Zone
    }

    public class AttributeReferenceTypeIdWrapper : IAttributeReferenceTypeId
    {
        public string JsonName { get; internal set; }
        public AttributeReferenceTypeId? Value { get; internal set; }
        public override string ToString()
        {
            return JsonName;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public new IEnumerator<char> GetEnumerator()
        {
            return JsonName.GetEnumerator();
        }
    }

    [EnumInterfaceCreator(typeof(IAttributeReferenceTypeId), "FindEnum")]
    public interface IAttributeReferenceTypeId : IJsonName, IEnumerable<char>
    {
        public static IAttributeReferenceTypeId Cart = new AttributeReferenceTypeIdWrapper
        { Value = AttributeReferenceTypeId.Cart, JsonName = "cart" };

        public static IAttributeReferenceTypeId Category = new AttributeReferenceTypeIdWrapper
        { Value = AttributeReferenceTypeId.Category, JsonName = "category" };

        public static IAttributeReferenceTypeId Channel = new AttributeReferenceTypeIdWrapper
        { Value = AttributeReferenceTypeId.Channel, JsonName = "channel" };

        public static IAttributeReferenceTypeId Customer = new AttributeReferenceTypeIdWrapper
        { Value = AttributeReferenceTypeId.Customer, JsonName = "customer" };

        public static IAttributeReferenceTypeId KeyValueDocument = new AttributeReferenceTypeIdWrapper
        { Value = AttributeReferenceTypeId.KeyValueDocument, JsonName = "key-value-document" };

        public static IAttributeReferenceTypeId Order = new AttributeReferenceTypeIdWrapper
        { Value = AttributeReferenceTypeId.Order, JsonName = "order" };

        public static IAttributeReferenceTypeId Product = new AttributeReferenceTypeIdWrapper
        { Value = AttributeReferenceTypeId.Product, JsonName = "product" };

        public static IAttributeReferenceTypeId ProductType = new AttributeReferenceTypeIdWrapper
        { Value = AttributeReferenceTypeId.ProductType, JsonName = "product-type" };

        public static IAttributeReferenceTypeId Review = new AttributeReferenceTypeIdWrapper
        { Value = AttributeReferenceTypeId.Review, JsonName = "review" };

        public static IAttributeReferenceTypeId ShippingMethod = new AttributeReferenceTypeIdWrapper
        { Value = AttributeReferenceTypeId.ShippingMethod, JsonName = "shipping-method" };

        public static IAttributeReferenceTypeId State = new AttributeReferenceTypeIdWrapper
        { Value = AttributeReferenceTypeId.State, JsonName = "state" };

        public static IAttributeReferenceTypeId Zone = new AttributeReferenceTypeIdWrapper
        { Value = AttributeReferenceTypeId.Zone, JsonName = "zone" };

        AttributeReferenceTypeId? Value { get; }

        static IAttributeReferenceTypeId[] Values()
        {
            return new[]
            {
                 Cart ,
                 Category ,
                 Channel ,
                 Customer ,
                 KeyValueDocument ,
                 Order ,
                 Product ,
                 ProductType ,
                 Review ,
                 ShippingMethod ,
                 State ,
                 Zone
             };
        }
        static IAttributeReferenceTypeId FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new AttributeReferenceTypeIdWrapper() { JsonName = value };
        }
    }
}
