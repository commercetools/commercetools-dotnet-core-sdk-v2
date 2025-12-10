using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Common
{
    public enum AddressRole
    {
        [Description("Shipping")]
        Shipping,

        [Description("Billing")]
        Billing
    }

    public class AddressRoleWrapper : IAddressRole
    {
        public string JsonName { get; internal set; }
        public AddressRole? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IAddressRole), "FindEnum")]
    public interface IAddressRole : IJsonName, IEnumerable<char>
    {
        public static IAddressRole Shipping = new AddressRoleWrapper
        { Value = AddressRole.Shipping, JsonName = "Shipping" };

        public static IAddressRole Billing = new AddressRoleWrapper
        { Value = AddressRole.Billing, JsonName = "Billing" };

        AddressRole? Value { get; }

        static IAddressRole[] Values()
        {
            return new[]
            {
                 Shipping ,
                 Billing
             };
        }
        static IAddressRole FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new AddressRoleWrapper() { JsonName = value };
        }
    }
}
