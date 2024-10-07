using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ApprovalRules
{
    public enum ApprovalRuleStatus
    {
        [Description("Active")]
        Active,

        [Description("Inactive")]
        Inactive
    }

    public class ApprovalRuleStatusWrapper : IApprovalRuleStatus
    {
        public string JsonName { get; internal set; }
        public ApprovalRuleStatus? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IApprovalRuleStatus), "FindEnum")]
    public interface IApprovalRuleStatus : IJsonName, IEnumerable<char>
    {
        public static IApprovalRuleStatus Active = new ApprovalRuleStatusWrapper
        { Value = ApprovalRuleStatus.Active, JsonName = "Active" };

        public static IApprovalRuleStatus Inactive = new ApprovalRuleStatusWrapper
        { Value = ApprovalRuleStatus.Inactive, JsonName = "Inactive" };

        ApprovalRuleStatus? Value { get; }

        static IApprovalRuleStatus[] Values()
        {
            return new[]
            {
                 Active ,
                 Inactive
             };
        }
        static IApprovalRuleStatus FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ApprovalRuleStatusWrapper() { JsonName = value };
        }
    }
}
