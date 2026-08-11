using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.McpServers
{
    public enum McpServerState
    {
        [Description("Enabled")]
        Enabled,

        [Description("Disabled")]
        Disabled
    }

    public class McpServerStateWrapper : IMcpServerState
    {
        public string JsonName { get; internal set; }
        public McpServerState? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IMcpServerState), "FindEnum")]
    public interface IMcpServerState : IJsonName, IEnumerable<char>
    {
        public static IMcpServerState Enabled = new McpServerStateWrapper
        { Value = McpServerState.Enabled, JsonName = "Enabled" };

        public static IMcpServerState Disabled = new McpServerStateWrapper
        { Value = McpServerState.Disabled, JsonName = "Disabled" };

        McpServerState? Value { get; }

        static IMcpServerState[] Values()
        {
            return new[]
            {
                 Enabled ,
                 Disabled
             };
        }
        static IMcpServerState FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new McpServerStateWrapper() { JsonName = value };
        }
    }
}
