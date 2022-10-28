using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    public enum BusinessUnitType
    {
        [Description("Company")]
        Company,

        [Description("Division")]
        Division
    }

    public class BusinessUnitTypeWrapper : IBusinessUnitType
    {
        public string JsonName { get; internal set; }
        public BusinessUnitType? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IBusinessUnitType), "FindEnum")]
    public interface IBusinessUnitType : IJsonName, IEnumerable<char>
    {
        public static IBusinessUnitType Company = new BusinessUnitTypeWrapper
        { Value = BusinessUnitType.Company, JsonName = "Company" };

        public static IBusinessUnitType Division = new BusinessUnitTypeWrapper
        { Value = BusinessUnitType.Division, JsonName = "Division" };

        BusinessUnitType? Value { get; }

        static IBusinessUnitType[] Values()
        {
            return new[]
            {
                 Company ,
                 Division
             };
        }
        static IBusinessUnitType FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new BusinessUnitTypeWrapper() { JsonName = value };
        }
    }
}
