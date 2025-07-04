using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Importcontainers
{
    public enum StrategyEnum
    {
        [Description("ttl")]
        Ttl
    }

    public class StrategyEnumWrapper : IStrategyEnum
    {
        public string JsonName { get; internal set; }
        public StrategyEnum? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IStrategyEnum), "FindEnum")]
    public interface IStrategyEnum : IJsonName, IEnumerable<char>
    {
        public static IStrategyEnum Ttl = new StrategyEnumWrapper
        { Value = StrategyEnum.Ttl, JsonName = "ttl" };

        StrategyEnum? Value { get; }

        static IStrategyEnum[] Values()
        {
            return new[]
            {
                 Ttl
             };
        }
        static IStrategyEnum FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new StrategyEnumWrapper() { JsonName = value };
        }
    }
}
