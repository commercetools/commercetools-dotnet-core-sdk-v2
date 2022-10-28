using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    public enum StateRole
    {
        [Description("ReviewIncludedInStatistics")]
        ReviewIncludedInStatistics,

        [Description("Return")]
        Return
    }

    public class StateRoleWrapper : IStateRole
    {
        public string JsonName { get; internal set; }
        public StateRole? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IStateRole), "FindEnum")]
    public interface IStateRole : IJsonName, IEnumerable<char>
    {
        public static IStateRole ReviewIncludedInStatistics = new StateRoleWrapper
        { Value = StateRole.ReviewIncludedInStatistics, JsonName = "ReviewIncludedInStatistics" };

        public static IStateRole Return = new StateRoleWrapper
        { Value = StateRole.Return, JsonName = "Return" };

        StateRole? Value { get; }

        static IStateRole[] Values()
        {
            return new[]
            {
                 ReviewIncludedInStatistics ,
                 Return
             };
        }
        static IStateRole FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new StateRoleWrapper() { JsonName = value };
        }
    }
}
