using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Api.Models.Carts
{
    public enum InventoryMode
    {
        [Description("TrackOnly")]
        TrackOnly,

        [Description("ReserveOnOrder")]
        ReserveOnOrder,

        [Description("None")]
        None
    }

    public class InventoryModeWrapper : IInventoryMode
    {
        public string JsonName { get; internal set; }
        public InventoryMode? Value { get; internal set; }
        public override string ToString()
        {
            return JsonName;
        }
    }

    [EnumInterfaceCreator(typeof(IInventoryMode), "FindEnum")]
    public interface IInventoryMode : IJsonName
    {
        public static IInventoryMode TrackOnly = new InventoryModeWrapper
        { Value = InventoryMode.TrackOnly, JsonName = "TrackOnly" };

        public static IInventoryMode ReserveOnOrder = new InventoryModeWrapper
        { Value = InventoryMode.ReserveOnOrder, JsonName = "ReserveOnOrder" };

        public static IInventoryMode None = new InventoryModeWrapper
        { Value = InventoryMode.None, JsonName = "None" };

        InventoryMode? Value { get; }

        static IInventoryMode[] Values()
        {
            return new[]
            {
                 TrackOnly ,
                 ReserveOnOrder ,
                 None
             };
        }
        static IInventoryMode FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new InventoryModeWrapper() { JsonName = value };
        }
    }
}
