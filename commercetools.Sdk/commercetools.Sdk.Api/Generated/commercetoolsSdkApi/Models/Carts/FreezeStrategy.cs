using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    public enum FreezeStrategy
    {
        [Description("SoftFreeze")]
        SoftFreeze,

        [Description("HardFreeze")]
        HardFreeze
    }

    public class FreezeStrategyWrapper : IFreezeStrategy
    {
        public string JsonName { get; internal set; }
        public FreezeStrategy? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IFreezeStrategy), "FindEnum")]
    public interface IFreezeStrategy : IJsonName, IEnumerable<char>
    {
        public static IFreezeStrategy SoftFreeze = new FreezeStrategyWrapper
        { Value = FreezeStrategy.SoftFreeze, JsonName = "SoftFreeze" };

        public static IFreezeStrategy HardFreeze = new FreezeStrategyWrapper
        { Value = FreezeStrategy.HardFreeze, JsonName = "HardFreeze" };

        FreezeStrategy? Value { get; }

        static IFreezeStrategy[] Values()
        {
            return new[]
            {
                 SoftFreeze ,
                 HardFreeze
             };
        }
        static IFreezeStrategy FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new FreezeStrategyWrapper() { JsonName = value };
        }
    }
}
