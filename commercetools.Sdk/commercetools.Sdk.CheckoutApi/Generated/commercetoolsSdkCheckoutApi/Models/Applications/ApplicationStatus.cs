using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Applications
{
    public enum ApplicationStatus
    {
        [Description("Active")]
        Active,

        [Description("Inactive")]
        Inactive
    }

    public class ApplicationStatusWrapper : IApplicationStatus
    {
        public string JsonName { get; internal set; }
        public ApplicationStatus? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IApplicationStatus), "FindEnum")]
    public interface IApplicationStatus : IJsonName, IEnumerable<char>
    {
        public static IApplicationStatus Active = new ApplicationStatusWrapper
        { Value = ApplicationStatus.Active, JsonName = "Active" };

        public static IApplicationStatus Inactive = new ApplicationStatusWrapper
        { Value = ApplicationStatus.Inactive, JsonName = "Inactive" };

        ApplicationStatus? Value { get; }

        static IApplicationStatus[] Values()
        {
            return new[]
            {
                 Active ,
                 Inactive
             };
        }
        static IApplicationStatus FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ApplicationStatusWrapper() { JsonName = value };
        }
    }
}
