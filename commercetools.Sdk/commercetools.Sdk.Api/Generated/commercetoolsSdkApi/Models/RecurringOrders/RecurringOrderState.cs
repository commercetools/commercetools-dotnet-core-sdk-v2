using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurringOrders
{
    public enum RecurringOrderState
    {
        [Description("Active")]
        Active,

        [Description("Paused")]
        Paused,

        [Description("Expired")]
        Expired,

        [Description("Canceled")]
        Canceled,

        [Description("Failed")]
        Failed
    }

    public class RecurringOrderStateWrapper : IRecurringOrderState
    {
        public string JsonName { get; internal set; }
        public RecurringOrderState? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IRecurringOrderState), "FindEnum")]
    public interface IRecurringOrderState : IJsonName, IEnumerable<char>
    {
        public static IRecurringOrderState Active = new RecurringOrderStateWrapper
        { Value = RecurringOrderState.Active, JsonName = "Active" };

        public static IRecurringOrderState Paused = new RecurringOrderStateWrapper
        { Value = RecurringOrderState.Paused, JsonName = "Paused" };

        public static IRecurringOrderState Expired = new RecurringOrderStateWrapper
        { Value = RecurringOrderState.Expired, JsonName = "Expired" };

        public static IRecurringOrderState Canceled = new RecurringOrderStateWrapper
        { Value = RecurringOrderState.Canceled, JsonName = "Canceled" };

        public static IRecurringOrderState Failed = new RecurringOrderStateWrapper
        { Value = RecurringOrderState.Failed, JsonName = "Failed" };

        RecurringOrderState? Value { get; }

        static IRecurringOrderState[] Values()
        {
            return new[]
            {
                 Active ,
                 Paused ,
                 Expired ,
                 Canceled ,
                 Failed
             };
        }
        static IRecurringOrderState FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new RecurringOrderStateWrapper() { JsonName = value };
        }
    }
}
