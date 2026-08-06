using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.McpServers
{
    public enum McpServerAuthenticationMode
    {
        [Description("ClientCredentials")]
        ClientCredentials,

        [Description("CommercetoolsIdentity")]
        CommercetoolsIdentity
    }

    public class McpServerAuthenticationModeWrapper : IMcpServerAuthenticationMode
    {
        public string JsonName { get; internal set; }
        public McpServerAuthenticationMode? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IMcpServerAuthenticationMode), "FindEnum")]
    public interface IMcpServerAuthenticationMode : IJsonName, IEnumerable<char>
    {
        public static IMcpServerAuthenticationMode ClientCredentials = new McpServerAuthenticationModeWrapper
        { Value = McpServerAuthenticationMode.ClientCredentials, JsonName = "ClientCredentials" };

        public static IMcpServerAuthenticationMode CommercetoolsIdentity = new McpServerAuthenticationModeWrapper
        { Value = McpServerAuthenticationMode.CommercetoolsIdentity, JsonName = "CommercetoolsIdentity" };

        McpServerAuthenticationMode? Value { get; }

        static IMcpServerAuthenticationMode[] Values()
        {
            return new[]
            {
                 ClientCredentials ,
                 CommercetoolsIdentity
             };
        }
        static IMcpServerAuthenticationMode FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new McpServerAuthenticationModeWrapper() { JsonName = value };
        }
    }
}
