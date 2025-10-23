using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    public enum BusinessUnitApprovalRuleMode
    {
        [Description("Explicit")]
        Explicit,

        [Description("ExplicitAndFromParent")]
        ExplicitAndFromParent
    }

    public class BusinessUnitApprovalRuleModeWrapper : IBusinessUnitApprovalRuleMode
    {
        public string JsonName { get; internal set; }
        public BusinessUnitApprovalRuleMode? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IBusinessUnitApprovalRuleMode), "FindEnum")]
    public interface IBusinessUnitApprovalRuleMode : IJsonName, IEnumerable<char>
    {
        public static IBusinessUnitApprovalRuleMode Explicit = new BusinessUnitApprovalRuleModeWrapper
        { Value = BusinessUnitApprovalRuleMode.Explicit, JsonName = "Explicit" };

        public static IBusinessUnitApprovalRuleMode ExplicitAndFromParent = new BusinessUnitApprovalRuleModeWrapper
        { Value = BusinessUnitApprovalRuleMode.ExplicitAndFromParent, JsonName = "ExplicitAndFromParent" };

        BusinessUnitApprovalRuleMode? Value { get; }

        static IBusinessUnitApprovalRuleMode[] Values()
        {
            return new[]
            {
                 Explicit ,
                 ExplicitAndFromParent
             };
        }
        static IBusinessUnitApprovalRuleMode FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new BusinessUnitApprovalRuleModeWrapper() { JsonName = value };
        }
    }
}
