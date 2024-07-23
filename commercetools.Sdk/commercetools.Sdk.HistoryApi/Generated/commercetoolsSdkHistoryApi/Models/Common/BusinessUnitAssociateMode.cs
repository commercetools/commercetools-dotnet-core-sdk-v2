using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    public enum BusinessUnitAssociateMode
    {
        [Description("Explicit")]
        Explicit,

        [Description("ExplicitAndFromParent")]
        ExplicitAndFromParent
    }

    public class BusinessUnitAssociateModeWrapper : IBusinessUnitAssociateMode
    {
        public string JsonName { get; internal set; }
        public BusinessUnitAssociateMode? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IBusinessUnitAssociateMode), "FindEnum")]
    public interface IBusinessUnitAssociateMode : IJsonName, IEnumerable<char>
    {
        public static IBusinessUnitAssociateMode Explicit = new BusinessUnitAssociateModeWrapper
        { Value = BusinessUnitAssociateMode.Explicit, JsonName = "Explicit" };

        public static IBusinessUnitAssociateMode ExplicitAndFromParent = new BusinessUnitAssociateModeWrapper
        { Value = BusinessUnitAssociateMode.ExplicitAndFromParent, JsonName = "ExplicitAndFromParent" };

        BusinessUnitAssociateMode? Value { get; }

        static IBusinessUnitAssociateMode[] Values()
        {
            return new[]
            {
                 Explicit ,
                 ExplicitAndFromParent
             };
        }
        static IBusinessUnitAssociateMode FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new BusinessUnitAssociateModeWrapper() { JsonName = value };
        }
    }
}
