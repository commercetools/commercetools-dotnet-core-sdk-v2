using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Applications
{
    public enum ApplicationAgreementStatus
    {
        [Description("Active")]
        Active,

        [Description("Inactive")]
        Inactive
    }

    public class ApplicationAgreementStatusWrapper : IApplicationAgreementStatus
    {
        public string JsonName { get; internal set; }
        public ApplicationAgreementStatus? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IApplicationAgreementStatus), "FindEnum")]
    public interface IApplicationAgreementStatus : IJsonName, IEnumerable<char>
    {
        public static IApplicationAgreementStatus Active = new ApplicationAgreementStatusWrapper
        { Value = ApplicationAgreementStatus.Active, JsonName = "Active" };

        public static IApplicationAgreementStatus Inactive = new ApplicationAgreementStatusWrapper
        { Value = ApplicationAgreementStatus.Inactive, JsonName = "Inactive" };

        ApplicationAgreementStatus? Value { get; }

        static IApplicationAgreementStatus[] Values()
        {
            return new[]
            {
                 Active ,
                 Inactive
             };
        }
        static IApplicationAgreementStatus FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ApplicationAgreementStatusWrapper() { JsonName = value };
        }
    }
}
