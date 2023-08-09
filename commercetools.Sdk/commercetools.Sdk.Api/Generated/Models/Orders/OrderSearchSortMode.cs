using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    public enum OrderSearchSortMode
    {
        [Description("min")]
        Min,

        [Description("max")]
        Max,

        [Description("avg")]
        Avg,

        [Description("sum")]
        Sum
    }

    public class OrderSearchSortModeWrapper : IOrderSearchSortMode
    {
        public string JsonName { get; internal set; }
        public OrderSearchSortMode? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IOrderSearchSortMode), "FindEnum")]
    public interface IOrderSearchSortMode : IJsonName, IEnumerable<char>
    {
        public static IOrderSearchSortMode Min = new OrderSearchSortModeWrapper
        { Value = OrderSearchSortMode.Min, JsonName = "min" };

        public static IOrderSearchSortMode Max = new OrderSearchSortModeWrapper
        { Value = OrderSearchSortMode.Max, JsonName = "max" };

        public static IOrderSearchSortMode Avg = new OrderSearchSortModeWrapper
        { Value = OrderSearchSortMode.Avg, JsonName = "avg" };

        public static IOrderSearchSortMode Sum = new OrderSearchSortModeWrapper
        { Value = OrderSearchSortMode.Sum, JsonName = "sum" };

        OrderSearchSortMode? Value { get; }

        static IOrderSearchSortMode[] Values()
        {
            return new[]
            {
                 Min ,
                 Max ,
                 Avg ,
                 Sum
             };
        }
        static IOrderSearchSortMode FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new OrderSearchSortModeWrapper() { JsonName = value };
        }
    }
}
