using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.ImportApi.Models.Types
{
    public enum CustomFieldReferenceValue
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

        [Description("state")]
        State,

        [Description("shipping-method")]
        ShippingMethod,

        [Description("zone")]
        Zone
    }

    public class CustomFieldReferenceValueWrapper : ICustomFieldReferenceValue
    {
        public string JsonName { get; internal set; }
        public CustomFieldReferenceValue? Value { get; internal set; }
        public override string ToString()
        {
            return JsonName;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<char> GetEnumerator()
        {
            return JsonName.GetEnumerator();
        }
    }

    [EnumInterfaceCreator(typeof(ICustomFieldReferenceValue), "FindEnum")]
    public interface ICustomFieldReferenceValue : IJsonName, IEnumerable<char>
    {
        public static ICustomFieldReferenceValue Cart = new CustomFieldReferenceValueWrapper
        { Value = CustomFieldReferenceValue.Cart, JsonName = "cart" };

        public static ICustomFieldReferenceValue Category = new CustomFieldReferenceValueWrapper
        { Value = CustomFieldReferenceValue.Category, JsonName = "category" };

        public static ICustomFieldReferenceValue Channel = new CustomFieldReferenceValueWrapper
        { Value = CustomFieldReferenceValue.Channel, JsonName = "channel" };

        public static ICustomFieldReferenceValue Customer = new CustomFieldReferenceValueWrapper
        { Value = CustomFieldReferenceValue.Customer, JsonName = "customer" };

        public static ICustomFieldReferenceValue KeyValueDocument = new CustomFieldReferenceValueWrapper
        { Value = CustomFieldReferenceValue.KeyValueDocument, JsonName = "key-value-document" };

        public static ICustomFieldReferenceValue Order = new CustomFieldReferenceValueWrapper
        { Value = CustomFieldReferenceValue.Order, JsonName = "order" };

        public static ICustomFieldReferenceValue Product = new CustomFieldReferenceValueWrapper
        { Value = CustomFieldReferenceValue.Product, JsonName = "product" };

        public static ICustomFieldReferenceValue ProductType = new CustomFieldReferenceValueWrapper
        { Value = CustomFieldReferenceValue.ProductType, JsonName = "product-type" };

        public static ICustomFieldReferenceValue Review = new CustomFieldReferenceValueWrapper
        { Value = CustomFieldReferenceValue.Review, JsonName = "review" };

        public static ICustomFieldReferenceValue State = new CustomFieldReferenceValueWrapper
        { Value = CustomFieldReferenceValue.State, JsonName = "state" };

        public static ICustomFieldReferenceValue ShippingMethod = new CustomFieldReferenceValueWrapper
        { Value = CustomFieldReferenceValue.ShippingMethod, JsonName = "shipping-method" };

        public static ICustomFieldReferenceValue Zone = new CustomFieldReferenceValueWrapper
        { Value = CustomFieldReferenceValue.Zone, JsonName = "zone" };

        CustomFieldReferenceValue? Value { get; }

        static ICustomFieldReferenceValue[] Values()
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
                 State ,
                 ShippingMethod ,
                 Zone
             };
        }
        static ICustomFieldReferenceValue FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new CustomFieldReferenceValueWrapper() { JsonName = value };
        }
    }
}
