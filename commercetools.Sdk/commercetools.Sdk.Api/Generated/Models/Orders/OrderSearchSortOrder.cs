using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    public enum OrderSearchSortOrder
    {
        [Description("asc")]
        Asc,

        [Description("desc")]
        Desc
    }

    public class OrderSearchSortOrderWrapper : IOrderSearchSortOrder
    {
        public string JsonName { get; internal set; }
        public OrderSearchSortOrder? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IOrderSearchSortOrder), "FindEnum")]
    public interface IOrderSearchSortOrder : IJsonName, IEnumerable<char>
    {
        public static IOrderSearchSortOrder Asc = new OrderSearchSortOrderWrapper
        { Value = OrderSearchSortOrder.Asc, JsonName = "asc" };

        public static IOrderSearchSortOrder Desc = new OrderSearchSortOrderWrapper
        { Value = OrderSearchSortOrder.Desc, JsonName = "desc" };

        OrderSearchSortOrder? Value { get; }

        static IOrderSearchSortOrder[] Values()
        {
            return new[]
            {
                 Asc ,
                 Desc
             };
        }
        static IOrderSearchSortOrder FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new OrderSearchSortOrderWrapper() { JsonName = value };
        }
    }
}
