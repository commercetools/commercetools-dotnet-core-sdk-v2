using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    public enum DiscountCombinationMode
    {
        [Description("BestDeal")]
        BestDeal,

        [Description("Stacking")]
        Stacking
    }

    public class DiscountCombinationModeWrapper : IDiscountCombinationMode
    {
        public string JsonName { get; internal set; }
        public DiscountCombinationMode? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IDiscountCombinationMode), "FindEnum")]
    public interface IDiscountCombinationMode : IJsonName, IEnumerable<char>
    {
        public static IDiscountCombinationMode BestDeal = new DiscountCombinationModeWrapper
        { Value = DiscountCombinationMode.BestDeal, JsonName = "BestDeal" };

        public static IDiscountCombinationMode Stacking = new DiscountCombinationModeWrapper
        { Value = DiscountCombinationMode.Stacking, JsonName = "Stacking" };

        DiscountCombinationMode? Value { get; }

        static IDiscountCombinationMode[] Values()
        {
            return new[]
            {
                 BestDeal ,
                 Stacking
             };
        }
        static IDiscountCombinationMode FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new DiscountCombinationModeWrapper() { JsonName = value };
        }
    }
}
