using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    public enum BusinessUnitSearchStatus
    {
        [Description("Activated")]
        Activated,

        [Description("Deactivated")]
        Deactivated
    }

    public class BusinessUnitSearchStatusWrapper : IBusinessUnitSearchStatus
    {
        public string JsonName { get; internal set; }
        public BusinessUnitSearchStatus? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IBusinessUnitSearchStatus), "FindEnum")]
    public interface IBusinessUnitSearchStatus : IJsonName, IEnumerable<char>
    {
        public static IBusinessUnitSearchStatus Activated = new BusinessUnitSearchStatusWrapper
        { Value = BusinessUnitSearchStatus.Activated, JsonName = "Activated" };

        public static IBusinessUnitSearchStatus Deactivated = new BusinessUnitSearchStatusWrapper
        { Value = BusinessUnitSearchStatus.Deactivated, JsonName = "Deactivated" };

        BusinessUnitSearchStatus? Value { get; }

        static IBusinessUnitSearchStatus[] Values()
        {
            return new[]
            {
                 Activated ,
                 Deactivated
             };
        }
        static IBusinessUnitSearchStatus FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new BusinessUnitSearchStatusWrapper() { JsonName = value };
        }
    }
}
