using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    public enum DiscountApplicationMode
    {
        [Description("ProportionateDistribution")]
        ProportionateDistribution,

        [Description("EvenDistribution")]
        EvenDistribution,

        [Description("IndividualApplication")]
        IndividualApplication
    }

    public class DiscountApplicationModeWrapper : IDiscountApplicationMode
    {
        public string JsonName { get; internal set; }
        public DiscountApplicationMode? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IDiscountApplicationMode), "FindEnum")]
    public interface IDiscountApplicationMode : IJsonName, IEnumerable<char>
    {
        public static IDiscountApplicationMode ProportionateDistribution = new DiscountApplicationModeWrapper
        { Value = DiscountApplicationMode.ProportionateDistribution, JsonName = "ProportionateDistribution" };

        public static IDiscountApplicationMode EvenDistribution = new DiscountApplicationModeWrapper
        { Value = DiscountApplicationMode.EvenDistribution, JsonName = "EvenDistribution" };

        public static IDiscountApplicationMode IndividualApplication = new DiscountApplicationModeWrapper
        { Value = DiscountApplicationMode.IndividualApplication, JsonName = "IndividualApplication" };

        DiscountApplicationMode? Value { get; }

        static IDiscountApplicationMode[] Values()
        {
            return new[]
            {
                 ProportionateDistribution ,
                 EvenDistribution ,
                 IndividualApplication
             };
        }
        static IDiscountApplicationMode FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new DiscountApplicationModeWrapper() { JsonName = value };
        }
    }
}
