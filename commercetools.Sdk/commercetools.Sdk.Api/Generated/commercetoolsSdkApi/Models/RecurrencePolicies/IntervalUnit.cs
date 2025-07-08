using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurrencePolicies
{
    public enum IntervalUnit
    {
        [Description("Days")]
        Days,

        [Description("Weeks")]
        Weeks,

        [Description("Months")]
        Months
    }

    public class IntervalUnitWrapper : IIntervalUnit
    {
        public string JsonName { get; internal set; }
        public IntervalUnit? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IIntervalUnit), "FindEnum")]
    public interface IIntervalUnit : IJsonName, IEnumerable<char>
    {
        public static IIntervalUnit Days = new IntervalUnitWrapper
        { Value = IntervalUnit.Days, JsonName = "Days" };

        public static IIntervalUnit Weeks = new IntervalUnitWrapper
        { Value = IntervalUnit.Weeks, JsonName = "Weeks" };

        public static IIntervalUnit Months = new IntervalUnitWrapper
        { Value = IntervalUnit.Months, JsonName = "Months" };

        IntervalUnit? Value { get; }

        static IIntervalUnit[] Values()
        {
            return new[]
            {
                 Days ,
                 Weeks ,
                 Months
             };
        }
        static IIntervalUnit FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new IntervalUnitWrapper() { JsonName = value };
        }
    }
}
