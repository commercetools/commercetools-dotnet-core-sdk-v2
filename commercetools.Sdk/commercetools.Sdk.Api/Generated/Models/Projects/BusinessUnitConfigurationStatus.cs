using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.Api.Models.Projects
{
    public enum BusinessUnitConfigurationStatus
    {
        [Description("Active")]
        Active,

        [Description("Inactive")]
        Inactive
    }

    public class BusinessUnitConfigurationStatusWrapper : IBusinessUnitConfigurationStatus
    {
        public string JsonName { get; internal set; }
        public BusinessUnitConfigurationStatus? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IBusinessUnitConfigurationStatus), "FindEnum")]
    public interface IBusinessUnitConfigurationStatus : IJsonName, IEnumerable<char>
    {
        public static IBusinessUnitConfigurationStatus Active = new BusinessUnitConfigurationStatusWrapper
        { Value = BusinessUnitConfigurationStatus.Active, JsonName = "Active" };

        public static IBusinessUnitConfigurationStatus Inactive = new BusinessUnitConfigurationStatusWrapper
        { Value = BusinessUnitConfigurationStatus.Inactive, JsonName = "Inactive" };

        BusinessUnitConfigurationStatus? Value { get; }

        static IBusinessUnitConfigurationStatus[] Values()
        {
            return new[]
            {
                 Active ,
                 Inactive
             };
        }
        static IBusinessUnitConfigurationStatus FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new BusinessUnitConfigurationStatusWrapper() { JsonName = value };
        }
    }
}
