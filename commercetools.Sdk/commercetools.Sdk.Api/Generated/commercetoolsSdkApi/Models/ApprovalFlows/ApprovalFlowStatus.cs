using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ApprovalFlows
{
    public enum ApprovalFlowStatus
    {
        [Description("Pending")]
        Pending,

        [Description("Approved")]
        Approved,

        [Description("Rejected")]
        Rejected
    }

    public class ApprovalFlowStatusWrapper : IApprovalFlowStatus
    {
        public string JsonName { get; internal set; }
        public ApprovalFlowStatus? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IApprovalFlowStatus), "FindEnum")]
    public interface IApprovalFlowStatus : IJsonName, IEnumerable<char>
    {
        public static IApprovalFlowStatus Pending = new ApprovalFlowStatusWrapper
        { Value = ApprovalFlowStatus.Pending, JsonName = "Pending" };

        public static IApprovalFlowStatus Approved = new ApprovalFlowStatusWrapper
        { Value = ApprovalFlowStatus.Approved, JsonName = "Approved" };

        public static IApprovalFlowStatus Rejected = new ApprovalFlowStatusWrapper
        { Value = ApprovalFlowStatus.Rejected, JsonName = "Rejected" };

        ApprovalFlowStatus? Value { get; }

        static IApprovalFlowStatus[] Values()
        {
            return new[]
            {
                 Pending ,
                 Approved ,
                 Rejected
             };
        }
        static IApprovalFlowStatus FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ApprovalFlowStatusWrapper() { JsonName = value };
        }
    }
}
