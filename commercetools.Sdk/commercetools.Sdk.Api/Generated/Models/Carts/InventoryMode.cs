using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.Api.Models.Carts
{
    public enum InventoryMode
    {
        [Description("None")]
        None,

        [Description("TrackOnly")]
        TrackOnly,

        [Description("ReserveOnOrder")]
        ReserveOnOrder
    }

    public class InventoryModeWrapper : IInventoryMode
    {
        public string JsonName { get; internal set; }
        public InventoryMode? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IInventoryMode), "FindEnum")]
    public interface IInventoryMode : IJsonName, IEnumerable<char>
    {
        public static IInventoryMode None = new InventoryModeWrapper
        { Value = InventoryMode.None, JsonName = "None" };

        public static IInventoryMode TrackOnly = new InventoryModeWrapper
        { Value = InventoryMode.TrackOnly, JsonName = "TrackOnly" };

        public static IInventoryMode ReserveOnOrder = new InventoryModeWrapper
        { Value = InventoryMode.ReserveOnOrder, JsonName = "ReserveOnOrder" };

        InventoryMode? Value { get; }

        static IInventoryMode[] Values()
        {
            return new[]
            {
                 None ,
                 TrackOnly ,
                 ReserveOnOrder
             };
        }
        static IInventoryMode FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new InventoryModeWrapper() { JsonName = value };
        }
    }
}
