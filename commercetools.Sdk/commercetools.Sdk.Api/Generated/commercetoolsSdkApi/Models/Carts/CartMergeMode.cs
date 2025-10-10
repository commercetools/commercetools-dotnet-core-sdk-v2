using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    public enum CartMergeMode
    {
        [Description("MergeWithExistingCustomerCart")]
        MergeWithExistingCustomerCart,

        [Description("UseAsNewActiveCustomerCart")]
        UseAsNewActiveCustomerCart
    }

    public class CartMergeModeWrapper : ICartMergeMode
    {
        public string JsonName { get; internal set; }
        public CartMergeMode? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(ICartMergeMode), "FindEnum")]
    public interface ICartMergeMode : IJsonName, IEnumerable<char>
    {
        public static ICartMergeMode MergeWithExistingCustomerCart = new CartMergeModeWrapper
        { Value = CartMergeMode.MergeWithExistingCustomerCart, JsonName = "MergeWithExistingCustomerCart" };

        public static ICartMergeMode UseAsNewActiveCustomerCart = new CartMergeModeWrapper
        { Value = CartMergeMode.UseAsNewActiveCustomerCart, JsonName = "UseAsNewActiveCustomerCart" };

        CartMergeMode? Value { get; }

        static ICartMergeMode[] Values()
        {
            return new[]
            {
                 MergeWithExistingCustomerCart ,
                 UseAsNewActiveCustomerCart
             };
        }
        static ICartMergeMode FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new CartMergeModeWrapper() { JsonName = value };
        }
    }
}
