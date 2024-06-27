using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    public enum CustomerIndexingStatus
    {
        [Description("Scheduled")]
        Scheduled,

        [Description("Indexing")]
        Indexing,

        [Description("Ready")]
        Ready,

        [Description("Failed")]
        Failed
    }

    public class CustomerIndexingStatusWrapper : ICustomerIndexingStatus
    {
        public string JsonName { get; internal set; }
        public CustomerIndexingStatus? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(ICustomerIndexingStatus), "FindEnum")]
    public interface ICustomerIndexingStatus : IJsonName, IEnumerable<char>
    {
        public static ICustomerIndexingStatus Scheduled = new CustomerIndexingStatusWrapper
        { Value = CustomerIndexingStatus.Scheduled, JsonName = "Scheduled" };

        public static ICustomerIndexingStatus Indexing = new CustomerIndexingStatusWrapper
        { Value = CustomerIndexingStatus.Indexing, JsonName = "Indexing" };

        public static ICustomerIndexingStatus Ready = new CustomerIndexingStatusWrapper
        { Value = CustomerIndexingStatus.Ready, JsonName = "Ready" };

        public static ICustomerIndexingStatus Failed = new CustomerIndexingStatusWrapper
        { Value = CustomerIndexingStatus.Failed, JsonName = "Failed" };

        CustomerIndexingStatus? Value { get; }

        static ICustomerIndexingStatus[] Values()
        {
            return new[]
            {
                 Scheduled ,
                 Indexing ,
                 Ready ,
                 Failed
             };
        }
        static ICustomerIndexingStatus FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new CustomerIndexingStatusWrapper() { JsonName = value };
        }
    }
}
