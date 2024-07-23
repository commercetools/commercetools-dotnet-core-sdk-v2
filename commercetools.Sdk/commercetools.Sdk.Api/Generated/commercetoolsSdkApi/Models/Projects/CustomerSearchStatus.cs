using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    public enum CustomerSearchStatus
    {
        [Description("Activated")]
        Activated,

        [Description("Deactivated")]
        Deactivated
    }

    public class CustomerSearchStatusWrapper : ICustomerSearchStatus
    {
        public string JsonName { get; internal set; }
        public CustomerSearchStatus? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(ICustomerSearchStatus), "FindEnum")]
    public interface ICustomerSearchStatus : IJsonName, IEnumerable<char>
    {
        public static ICustomerSearchStatus Activated = new CustomerSearchStatusWrapper
        { Value = CustomerSearchStatus.Activated, JsonName = "Activated" };

        public static ICustomerSearchStatus Deactivated = new CustomerSearchStatusWrapper
        { Value = CustomerSearchStatus.Deactivated, JsonName = "Deactivated" };

        CustomerSearchStatus? Value { get; }

        static ICustomerSearchStatus[] Values()
        {
            return new[]
            {
                 Activated ,
                 Deactivated
             };
        }
        static ICustomerSearchStatus FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new CustomerSearchStatusWrapper() { JsonName = value };
        }
    }
}
