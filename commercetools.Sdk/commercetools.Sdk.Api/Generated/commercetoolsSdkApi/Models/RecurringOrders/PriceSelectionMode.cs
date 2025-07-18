using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurringOrders
{
    public enum PriceSelectionMode
    {
        [Description("Fixed")]
        Fixed,

        [Description("Dynamic")]
        Dynamic
    }

    public class PriceSelectionModeWrapper : IPriceSelectionMode
    {
        public string JsonName { get; internal set; }
        public PriceSelectionMode? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IPriceSelectionMode), "FindEnum")]
    public interface IPriceSelectionMode : IJsonName, IEnumerable<char>
    {
        public static IPriceSelectionMode Fixed = new PriceSelectionModeWrapper
        { Value = PriceSelectionMode.Fixed, JsonName = "Fixed" };

        public static IPriceSelectionMode Dynamic = new PriceSelectionModeWrapper
        { Value = PriceSelectionMode.Dynamic, JsonName = "Dynamic" };

        PriceSelectionMode? Value { get; }

        static IPriceSelectionMode[] Values()
        {
            return new[]
            {
                 Fixed ,
                 Dynamic
             };
        }
        static IPriceSelectionMode FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new PriceSelectionModeWrapper() { JsonName = value };
        }
    }
}
