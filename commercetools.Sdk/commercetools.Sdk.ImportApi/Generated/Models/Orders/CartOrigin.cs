using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.ImportApi.Models.Orders
{
    public enum CartOrigin
    {
        [Description("Customer")]
        Customer,

        [Description("Merchant")]
        Merchant
    }

    public class CartOriginWrapper : ICartOrigin
    {
        public string JsonName { get; internal set; }
        public CartOrigin? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(ICartOrigin), "FindEnum")]
    public interface ICartOrigin : IJsonName, IEnumerable<char>
    {
        public static ICartOrigin Customer = new CartOriginWrapper
        { Value = CartOrigin.Customer, JsonName = "Customer" };

        public static ICartOrigin Merchant = new CartOriginWrapper
        { Value = CartOrigin.Merchant, JsonName = "Merchant" };

        CartOrigin? Value { get; }

        static ICartOrigin[] Values()
        {
            return new[]
            {
                 Customer ,
                 Merchant
             };
        }
        static ICartOrigin FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new CartOriginWrapper() { JsonName = value };
        }
    }
}
