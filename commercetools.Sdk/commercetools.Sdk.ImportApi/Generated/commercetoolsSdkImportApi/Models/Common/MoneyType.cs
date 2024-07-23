using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Common
{
    public enum MoneyType
    {
        [Description("centPrecision")]
        CentPrecision,

        [Description("highPrecision")]
        HighPrecision
    }

    public class MoneyTypeWrapper : IMoneyType
    {
        public string JsonName { get; internal set; }
        public MoneyType? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IMoneyType), "FindEnum")]
    public interface IMoneyType : IJsonName, IEnumerable<char>
    {
        public static IMoneyType CentPrecision = new MoneyTypeWrapper
        { Value = MoneyType.CentPrecision, JsonName = "centPrecision" };

        public static IMoneyType HighPrecision = new MoneyTypeWrapper
        { Value = MoneyType.HighPrecision, JsonName = "highPrecision" };

        MoneyType? Value { get; }

        static IMoneyType[] Values()
        {
            return new[]
            {
                 CentPrecision ,
                 HighPrecision
             };
        }
        static IMoneyType FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new MoneyTypeWrapper() { JsonName = value };
        }
    }
}
