using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Agents
{
    public enum AgentResponsesOutputType
    {
        [Description("Cart")]
        Cart,

        [Description("QuoteRequest")]
        QuoteRequest
    }

    public class AgentResponsesOutputTypeWrapper : IAgentResponsesOutputType
    {
        public string JsonName { get; internal set; }
        public AgentResponsesOutputType? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IAgentResponsesOutputType), "FindEnum")]
    public interface IAgentResponsesOutputType : IJsonName, IEnumerable<char>
    {
        public static IAgentResponsesOutputType Cart = new AgentResponsesOutputTypeWrapper
        { Value = AgentResponsesOutputType.Cart, JsonName = "Cart" };

        public static IAgentResponsesOutputType QuoteRequest = new AgentResponsesOutputTypeWrapper
        { Value = AgentResponsesOutputType.QuoteRequest, JsonName = "QuoteRequest" };

        AgentResponsesOutputType? Value { get; }

        static IAgentResponsesOutputType[] Values()
        {
            return new[]
            {
                 Cart ,
                 QuoteRequest
             };
        }
        static IAgentResponsesOutputType FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new AgentResponsesOutputTypeWrapper() { JsonName = value };
        }
    }
}
