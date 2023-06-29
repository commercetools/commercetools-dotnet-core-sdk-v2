using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    public enum BusinessUnitStatus
    {
        [Description("Active")]
        Active,

        [Description("Inactive")]
        Inactive
    }

    public class BusinessUnitStatusWrapper : IBusinessUnitStatus
    {
        public string JsonName { get; internal set; }
        public BusinessUnitStatus? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IBusinessUnitStatus), "FindEnum")]
    public interface IBusinessUnitStatus : IJsonName, IEnumerable<char>
    {
        public static IBusinessUnitStatus Active = new BusinessUnitStatusWrapper
        { Value = BusinessUnitStatus.Active, JsonName = "Active" };

        public static IBusinessUnitStatus Inactive = new BusinessUnitStatusWrapper
        { Value = BusinessUnitStatus.Inactive, JsonName = "Inactive" };

        BusinessUnitStatus? Value { get; }

        static IBusinessUnitStatus[] Values()
        {
            return new[]
            {
                 Active ,
                 Inactive
             };
        }
        static IBusinessUnitStatus FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new BusinessUnitStatusWrapper() { JsonName = value };
        }
    }
}
