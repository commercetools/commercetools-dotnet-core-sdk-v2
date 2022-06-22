using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.Api.Models.Orders
{
    public enum OrderState
    {
        [Description("Open")]
        Open,

        [Description("Confirmed")]
        Confirmed,

        [Description("Complete")]
        Complete,

        [Description("Cancelled")]
        Cancelled
    }

    public class OrderStateWrapper : IOrderState
    {
        public string JsonName { get; internal set; }
        public OrderState? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IOrderState), "FindEnum")]
    public interface IOrderState : IJsonName, IEnumerable<char>
    {
        public static IOrderState Open = new OrderStateWrapper
        { Value = OrderState.Open, JsonName = "Open" };

        public static IOrderState Confirmed = new OrderStateWrapper
        { Value = OrderState.Confirmed, JsonName = "Confirmed" };

        public static IOrderState Complete = new OrderStateWrapper
        { Value = OrderState.Complete, JsonName = "Complete" };

        public static IOrderState Cancelled = new OrderStateWrapper
        { Value = OrderState.Cancelled, JsonName = "Cancelled" };

        OrderState? Value { get; }

        static IOrderState[] Values()
        {
            return new[]
            {
                 Open ,
                 Confirmed ,
                 Complete ,
                 Cancelled
             };
        }
        static IOrderState FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new OrderStateWrapper() { JsonName = value };
        }
    }
}
