using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.MLApi.Models.Common
{
    public enum TaskStatusEnum
    {
        [Description("PENDING")]
        Pending,

        [Description("SUCCESS")]
        Success
    }

    public class TaskStatusEnumWrapper : ITaskStatusEnum
    {
        public string JsonName { get; internal set; }
        public TaskStatusEnum? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(ITaskStatusEnum), "FindEnum")]
    public interface ITaskStatusEnum : IJsonName, IEnumerable<char>
    {
        public static ITaskStatusEnum Pending = new TaskStatusEnumWrapper
        { Value = TaskStatusEnum.Pending, JsonName = "PENDING" };

        public static ITaskStatusEnum Success = new TaskStatusEnumWrapper
        { Value = TaskStatusEnum.Success, JsonName = "SUCCESS" };

        TaskStatusEnum? Value { get; }

        static ITaskStatusEnum[] Values()
        {
            return new[]
            {
                 Pending ,
                 Success
             };
        }
        static ITaskStatusEnum FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new TaskStatusEnumWrapper() { JsonName = value };
        }
    }
}
