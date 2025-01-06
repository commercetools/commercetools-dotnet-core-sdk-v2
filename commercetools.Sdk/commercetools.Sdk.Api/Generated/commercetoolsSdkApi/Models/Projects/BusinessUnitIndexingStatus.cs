using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    public enum BusinessUnitIndexingStatus
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

    public class BusinessUnitIndexingStatusWrapper : IBusinessUnitIndexingStatus
    {
        public string JsonName { get; internal set; }
        public BusinessUnitIndexingStatus? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IBusinessUnitIndexingStatus), "FindEnum")]
    public interface IBusinessUnitIndexingStatus : IJsonName, IEnumerable<char>
    {
        public static IBusinessUnitIndexingStatus Scheduled = new BusinessUnitIndexingStatusWrapper
        { Value = BusinessUnitIndexingStatus.Scheduled, JsonName = "Scheduled" };

        public static IBusinessUnitIndexingStatus Indexing = new BusinessUnitIndexingStatusWrapper
        { Value = BusinessUnitIndexingStatus.Indexing, JsonName = "Indexing" };

        public static IBusinessUnitIndexingStatus Ready = new BusinessUnitIndexingStatusWrapper
        { Value = BusinessUnitIndexingStatus.Ready, JsonName = "Ready" };

        public static IBusinessUnitIndexingStatus Failed = new BusinessUnitIndexingStatusWrapper
        { Value = BusinessUnitIndexingStatus.Failed, JsonName = "Failed" };

        BusinessUnitIndexingStatus? Value { get; }

        static IBusinessUnitIndexingStatus[] Values()
        {
            return new[]
            {
                 Scheduled ,
                 Indexing ,
                 Ready ,
                 Failed
             };
        }
        static IBusinessUnitIndexingStatus FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new BusinessUnitIndexingStatusWrapper() { JsonName = value };
        }
    }
}
