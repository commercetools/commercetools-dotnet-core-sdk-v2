using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.McpServers
{
    public enum McpServerToolOutputFormatting
    {
        [Description("JsonToTabular")]
        JsonToTabular
    }

    public class McpServerToolOutputFormattingWrapper : IMcpServerToolOutputFormatting
    {
        public string JsonName { get; internal set; }
        public McpServerToolOutputFormatting? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IMcpServerToolOutputFormatting), "FindEnum")]
    public interface IMcpServerToolOutputFormatting : IJsonName, IEnumerable<char>
    {
        public static IMcpServerToolOutputFormatting JsonToTabular = new McpServerToolOutputFormattingWrapper
        { Value = McpServerToolOutputFormatting.JsonToTabular, JsonName = "JsonToTabular" };

        McpServerToolOutputFormatting? Value { get; }

        static IMcpServerToolOutputFormatting[] Values()
        {
            return new[]
            {
                 JsonToTabular
             };
        }
        static IMcpServerToolOutputFormatting FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new McpServerToolOutputFormattingWrapper() { JsonName = value };
        }
    }
}
