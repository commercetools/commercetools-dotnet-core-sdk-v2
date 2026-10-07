using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.RecurringPaymentJobs
{
    public enum RecurringPaymentJobState
    {
        [Description("Initial")]
        Initial,

        [Description("Pending")]
        Pending,

        [Description("Completed")]
        Completed,

        [Description("Failed")]
        Failed
    }

    public class RecurringPaymentJobStateWrapper : IRecurringPaymentJobState
    {
        public string JsonName { get; internal set; }
        public RecurringPaymentJobState? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IRecurringPaymentJobState), "FindEnum")]
    public interface IRecurringPaymentJobState : IJsonName, IEnumerable<char>
    {
        public static IRecurringPaymentJobState Initial = new RecurringPaymentJobStateWrapper
        { Value = RecurringPaymentJobState.Initial, JsonName = "Initial" };

        public static IRecurringPaymentJobState Pending = new RecurringPaymentJobStateWrapper
        { Value = RecurringPaymentJobState.Pending, JsonName = "Pending" };

        public static IRecurringPaymentJobState Completed = new RecurringPaymentJobStateWrapper
        { Value = RecurringPaymentJobState.Completed, JsonName = "Completed" };

        public static IRecurringPaymentJobState Failed = new RecurringPaymentJobStateWrapper
        { Value = RecurringPaymentJobState.Failed, JsonName = "Failed" };

        RecurringPaymentJobState? Value { get; }

        static IRecurringPaymentJobState[] Values()
        {
            return new[]
            {
                 Initial ,
                 Pending ,
                 Completed ,
                 Failed
             };
        }
        static IRecurringPaymentJobState FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new RecurringPaymentJobStateWrapper() { JsonName = value };
        }
    }
}
