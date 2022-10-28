using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    public enum RoundingMode
    {
        [Description("HalfEven")]
        HalfEven,

        [Description("HalfUp")]
        HalfUp,

        [Description("HalfDown")]
        HalfDown
    }

    public class RoundingModeWrapper : IRoundingMode
    {
        public string JsonName { get; internal set; }
        public RoundingMode? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IRoundingMode), "FindEnum")]
    public interface IRoundingMode : IJsonName, IEnumerable<char>
    {
        public static IRoundingMode HalfEven = new RoundingModeWrapper
        { Value = RoundingMode.HalfEven, JsonName = "HalfEven" };

        public static IRoundingMode HalfUp = new RoundingModeWrapper
        { Value = RoundingMode.HalfUp, JsonName = "HalfUp" };

        public static IRoundingMode HalfDown = new RoundingModeWrapper
        { Value = RoundingMode.HalfDown, JsonName = "HalfDown" };

        RoundingMode? Value { get; }

        static IRoundingMode[] Values()
        {
            return new[]
            {
                 HalfEven ,
                 HalfUp ,
                 HalfDown
             };
        }
        static IRoundingMode FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new RoundingModeWrapper() { JsonName = value };
        }
    }
}
