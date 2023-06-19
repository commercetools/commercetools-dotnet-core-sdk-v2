using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Channels
{
    public enum ChannelRoleEnum
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

    public class ChannelRoleEnumWrapper : IChannelRoleEnum
    {
        public string JsonName { get; internal set; }
        public ChannelRoleEnum? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IChannelRoleEnum), "FindEnum")]
    public interface IChannelRoleEnum : IJsonName, IEnumerable<char>
    {
        public static IChannelRoleEnum InventorySupply = new ChannelRoleEnumWrapper
        { Value = ChannelRoleEnum.InventorySupply, JsonName = "InventorySupply" };

        public static IChannelRoleEnum ProductDistribution = new ChannelRoleEnumWrapper
        { Value = ChannelRoleEnum.ProductDistribution, JsonName = "ProductDistribution" };

        public static IChannelRoleEnum OrderExport = new ChannelRoleEnumWrapper
        { Value = ChannelRoleEnum.OrderExport, JsonName = "OrderExport" };

        public static IChannelRoleEnum OrderImport = new ChannelRoleEnumWrapper
        { Value = ChannelRoleEnum.OrderImport, JsonName = "OrderImport" };

        public static IChannelRoleEnum Primary = new ChannelRoleEnumWrapper
        { Value = ChannelRoleEnum.Primary, JsonName = "Primary" };

        ChannelRoleEnum? Value { get; }

        static IChannelRoleEnum[] Values()
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
        static IChannelRoleEnum FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ChannelRoleEnumWrapper() { JsonName = value };
        }
    }
}
