using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.States
{
    public enum StateRoleEnum
    {
        [Description("ReviewIncludedInStatistics")]
        ReviewIncludedInStatistics,

        [Description("Return")]
        Return
    }

    public class StateRoleEnumWrapper : IStateRoleEnum
    {
        public string JsonName { get; internal set; }
        public StateRoleEnum? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IStateRoleEnum), "FindEnum")]
    public interface IStateRoleEnum : IJsonName, IEnumerable<char>
    {
        public static IStateRoleEnum ReviewIncludedInStatistics = new StateRoleEnumWrapper
        { Value = StateRoleEnum.ReviewIncludedInStatistics, JsonName = "ReviewIncludedInStatistics" };

        public static IStateRoleEnum Return = new StateRoleEnumWrapper
        { Value = StateRoleEnum.Return, JsonName = "Return" };

        StateRoleEnum? Value { get; }

        static IStateRoleEnum[] Values()
        {
            return new[]
            {
                 ReviewIncludedInStatistics ,
                 Return
             };
        }
        static IStateRoleEnum FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new StateRoleEnumWrapper() { JsonName = value };
        }
    }
}
