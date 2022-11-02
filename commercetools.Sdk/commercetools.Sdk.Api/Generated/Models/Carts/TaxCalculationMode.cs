using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.Api.Models.Carts
{
    public enum TaxCalculationMode
    {
        [Description("LineItemLevel")]
        LineItemLevel,

        [Description("UnitPriceLevel")]
        UnitPriceLevel
    }

    public class TaxCalculationModeWrapper : ITaxCalculationMode
    {
        public string JsonName { get; internal set; }
        public TaxCalculationMode? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(ITaxCalculationMode), "FindEnum")]
    public interface ITaxCalculationMode : IJsonName, IEnumerable<char>
    {
        public static ITaxCalculationMode LineItemLevel = new TaxCalculationModeWrapper
        { Value = TaxCalculationMode.LineItemLevel, JsonName = "LineItemLevel" };

        public static ITaxCalculationMode UnitPriceLevel = new TaxCalculationModeWrapper
        { Value = TaxCalculationMode.UnitPriceLevel, JsonName = "UnitPriceLevel" };

        TaxCalculationMode? Value { get; }

        static ITaxCalculationMode[] Values()
        {
            return new[]
            {
                 LineItemLevel ,
                 UnitPriceLevel
             };
        }
        static ITaxCalculationMode FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new TaxCalculationModeWrapper() { JsonName = value };
        }
    }
}
