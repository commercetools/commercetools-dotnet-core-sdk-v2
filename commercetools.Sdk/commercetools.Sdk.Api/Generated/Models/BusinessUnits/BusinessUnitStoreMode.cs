using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    public enum BusinessUnitStoreMode
    {
        [Description("Explicit")]
        Explicit,

        [Description("FromParent")]
        FromParent
    }

    public class BusinessUnitStoreModeWrapper : IBusinessUnitStoreMode
    {
        public string JsonName { get; internal set; }
        public BusinessUnitStoreMode? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IBusinessUnitStoreMode), "FindEnum")]
    public interface IBusinessUnitStoreMode : IJsonName, IEnumerable<char>
    {
        public static IBusinessUnitStoreMode Explicit = new BusinessUnitStoreModeWrapper
        { Value = BusinessUnitStoreMode.Explicit, JsonName = "Explicit" };

        public static IBusinessUnitStoreMode FromParent = new BusinessUnitStoreModeWrapper
        { Value = BusinessUnitStoreMode.FromParent, JsonName = "FromParent" };

        BusinessUnitStoreMode? Value { get; }

        static IBusinessUnitStoreMode[] Values()
        {
            return new[]
            {
                 Explicit ,
                 FromParent
             };
        }
        static IBusinessUnitStoreMode FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new BusinessUnitStoreModeWrapper() { JsonName = value };
        }
    }
}
