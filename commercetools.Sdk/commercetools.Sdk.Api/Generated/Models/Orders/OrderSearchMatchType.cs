using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.Api.Models.Orders
{
    public enum OrderSearchMatchType
    {
        [Description("any")]
        Any,

        [Description("all")]
        All
    }

    public class OrderSearchMatchTypeWrapper : IOrderSearchMatchType
    {
        public string JsonName { get; internal set; }
        public OrderSearchMatchType? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IOrderSearchMatchType), "FindEnum")]
    public interface IOrderSearchMatchType : IJsonName, IEnumerable<char>
    {
        public static IOrderSearchMatchType Any = new OrderSearchMatchTypeWrapper
        { Value = OrderSearchMatchType.Any, JsonName = "any" };

        public static IOrderSearchMatchType All = new OrderSearchMatchTypeWrapper
        { Value = OrderSearchMatchType.All, JsonName = "all" };

        OrderSearchMatchType? Value { get; }

        static IOrderSearchMatchType[] Values()
        {
            return new[]
            {
                 Any ,
                 All
             };
        }
        static IOrderSearchMatchType FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new OrderSearchMatchTypeWrapper() { JsonName = value };
        }
    }
}
