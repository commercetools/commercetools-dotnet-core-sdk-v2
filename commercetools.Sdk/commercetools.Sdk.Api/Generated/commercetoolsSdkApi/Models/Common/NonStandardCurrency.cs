using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Common
{
    public enum NonStandardCurrency
    {
        [Description("CZK0")]
        Czk0,

        [Description("HUF0")]
        Huf0,

        [Description("ILS0")]
        Ils0,

        [Description("KZT0")]
        Kzt0,

        [Description("TRY0")]
        Try0,

        [Description("TWD0")]
        Twd0
    }

    public class NonStandardCurrencyWrapper : INonStandardCurrency
    {
        public string JsonName { get; internal set; }
        public NonStandardCurrency? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(INonStandardCurrency), "FindEnum")]
    public interface INonStandardCurrency : IJsonName, IEnumerable<char>
    {
        public static INonStandardCurrency Czk0 = new NonStandardCurrencyWrapper
        { Value = NonStandardCurrency.Czk0, JsonName = "CZK0" };

        public static INonStandardCurrency Huf0 = new NonStandardCurrencyWrapper
        { Value = NonStandardCurrency.Huf0, JsonName = "HUF0" };

        public static INonStandardCurrency Ils0 = new NonStandardCurrencyWrapper
        { Value = NonStandardCurrency.Ils0, JsonName = "ILS0" };

        public static INonStandardCurrency Kzt0 = new NonStandardCurrencyWrapper
        { Value = NonStandardCurrency.Kzt0, JsonName = "KZT0" };

        public static INonStandardCurrency Try0 = new NonStandardCurrencyWrapper
        { Value = NonStandardCurrency.Try0, JsonName = "TRY0" };

        public static INonStandardCurrency Twd0 = new NonStandardCurrencyWrapper
        { Value = NonStandardCurrency.Twd0, JsonName = "TWD0" };

        NonStandardCurrency? Value { get; }

        static INonStandardCurrency[] Values()
        {
            return new[]
            {
                 Czk0 ,
                 Huf0 ,
                 Ils0 ,
                 Kzt0 ,
                 Try0 ,
                 Twd0
             };
        }
        static INonStandardCurrency FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new NonStandardCurrencyWrapper() { JsonName = value };
        }
    }
}
