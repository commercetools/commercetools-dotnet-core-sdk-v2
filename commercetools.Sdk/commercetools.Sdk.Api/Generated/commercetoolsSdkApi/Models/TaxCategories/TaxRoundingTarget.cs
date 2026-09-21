using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.TaxCategories
{
    public enum TaxRoundingTarget
    {
        [Description("Net")]
        Net,

        [Description("Tax")]
        Tax
    }

    public class TaxRoundingTargetWrapper : ITaxRoundingTarget
    {
        public string JsonName { get; internal set; }
        public TaxRoundingTarget? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(ITaxRoundingTarget), "FindEnum")]
    public interface ITaxRoundingTarget : IJsonName, IEnumerable<char>
    {
        public static ITaxRoundingTarget Net = new TaxRoundingTargetWrapper
        { Value = TaxRoundingTarget.Net, JsonName = "Net" };

        public static ITaxRoundingTarget Tax = new TaxRoundingTargetWrapper
        { Value = TaxRoundingTarget.Tax, JsonName = "Tax" };

        TaxRoundingTarget? Value { get; }

        static ITaxRoundingTarget[] Values()
        {
            return new[]
            {
                 Net ,
                 Tax
             };
        }
        static ITaxRoundingTarget FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new TaxRoundingTargetWrapper() { JsonName = value };
        }
    }
}
