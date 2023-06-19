using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    public enum ChannelRole
    {
        [Description("InventorySupply")]
        InventorySupply,

        [Description("ProductDistribution")]
        ProductDistribution,

        [Description("OrderExport")]
        OrderExport,

        [Description("OrderImport")]
        OrderImport,

        [Description("Primary")]
        Primary
    }

    public class ChannelRoleWrapper : IChannelRole
    {
        public string JsonName { get; internal set; }
        public ChannelRole? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IChannelRole), "FindEnum")]
    public interface IChannelRole : IJsonName, IEnumerable<char>
    {
        public static IChannelRole InventorySupply = new ChannelRoleWrapper
        { Value = ChannelRole.InventorySupply, JsonName = "InventorySupply" };

        public static IChannelRole ProductDistribution = new ChannelRoleWrapper
        { Value = ChannelRole.ProductDistribution, JsonName = "ProductDistribution" };

        public static IChannelRole OrderExport = new ChannelRoleWrapper
        { Value = ChannelRole.OrderExport, JsonName = "OrderExport" };

        public static IChannelRole OrderImport = new ChannelRoleWrapper
        { Value = ChannelRole.OrderImport, JsonName = "OrderImport" };

        public static IChannelRole Primary = new ChannelRoleWrapper
        { Value = ChannelRole.Primary, JsonName = "Primary" };

        ChannelRole? Value { get; }

        static IChannelRole[] Values()
        {
            return new[]
            {
                 InventorySupply ,
                 ProductDistribution ,
                 OrderExport ,
                 OrderImport ,
                 Primary
             };
        }
        static IChannelRole FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ChannelRoleWrapper() { JsonName = value };
        }
    }
}
