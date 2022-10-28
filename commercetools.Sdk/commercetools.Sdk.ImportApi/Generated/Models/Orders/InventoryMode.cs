using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.ImportApi.Models.Orders
{
    public enum InventoryMode
    {
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

        public new IEnumerator<char> GetEnumerator()
        {
            return JsonName.GetEnumerator();
        }
    }

    [EnumInterfaceCreator(typeof(IInventoryMode), "FindEnum")]
    public interface IInventoryMode : IJsonName, IEnumerable<char>
    {
        public static IInventoryMode TrackOnly = new InventoryModeWrapper
        { Value = InventoryMode.TrackOnly, JsonName = "TrackOnly" };

        public static IInventoryMode ReserveOnOrder = new InventoryModeWrapper
        { Value = InventoryMode.ReserveOnOrder, JsonName = "ReserveOnOrder" };

        InventoryMode? Value { get; }

        static IInventoryMode[] Values()
        {
            return new[]
            {
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
