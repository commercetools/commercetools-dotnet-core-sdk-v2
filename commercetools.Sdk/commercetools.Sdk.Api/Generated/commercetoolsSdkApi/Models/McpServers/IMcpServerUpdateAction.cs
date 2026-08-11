using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.McpServers
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.McpServers.McpServerUpdateAction))]
    [SubTypeDiscriminator("addTool", typeof(commercetools.Sdk.Api.Models.McpServers.McpServerAddToolAction))]
    [SubTypeDiscriminator("addToolCustomization", typeof(commercetools.Sdk.Api.Models.McpServers.McpServerAddToolCustomizationAction))]
    [SubTypeDiscriminator("removeTool", typeof(commercetools.Sdk.Api.Models.McpServers.McpServerRemoveToolAction))]
    [SubTypeDiscriminator("removeToolCustomization", typeof(commercetools.Sdk.Api.Models.McpServers.McpServerRemoveToolCustomizationAction))]
    [SubTypeDiscriminator("setAuthenticationMode", typeof(commercetools.Sdk.Api.Models.McpServers.McpServerSetAuthenticationModeAction))]
    [SubTypeDiscriminator("setDescription", typeof(commercetools.Sdk.Api.Models.McpServers.McpServerSetDescriptionAction))]
    [SubTypeDiscriminator("setJsonOutputFiltering", typeof(commercetools.Sdk.Api.Models.McpServers.McpServerSetJsonOutputFilteringAction))]
    [SubTypeDiscriminator("setName", typeof(commercetools.Sdk.Api.Models.McpServers.McpServerSetNameAction))]
    [SubTypeDiscriminator("setState", typeof(commercetools.Sdk.Api.Models.McpServers.McpServerSetStateAction))]
    [SubTypeDiscriminator("setToolCustomizations", typeof(commercetools.Sdk.Api.Models.McpServers.McpServerSetToolCustomizationsAction))]
    [SubTypeDiscriminator("setToolOutputFormatting", typeof(commercetools.Sdk.Api.Models.McpServers.McpServerSetToolOutputFormattingAction))]
    [SubTypeDiscriminator("setTools", typeof(commercetools.Sdk.Api.Models.McpServers.McpServerSetToolsAction))]
    public partial interface IMcpServerUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.McpServers.McpServerAddToolAction AddTool(Action<commercetools.Sdk.Api.Models.McpServers.McpServerAddToolAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.McpServers.McpServerAddToolAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.McpServers.McpServerAddToolCustomizationAction AddToolCustomization(Action<commercetools.Sdk.Api.Models.McpServers.McpServerAddToolCustomizationAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.McpServers.McpServerAddToolCustomizationAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.McpServers.McpServerRemoveToolAction RemoveTool(Action<commercetools.Sdk.Api.Models.McpServers.McpServerRemoveToolAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.McpServers.McpServerRemoveToolAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.McpServers.McpServerRemoveToolCustomizationAction RemoveToolCustomization(Action<commercetools.Sdk.Api.Models.McpServers.McpServerRemoveToolCustomizationAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.McpServers.McpServerRemoveToolCustomizationAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.McpServers.McpServerSetAuthenticationModeAction SetAuthenticationMode(Action<commercetools.Sdk.Api.Models.McpServers.McpServerSetAuthenticationModeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.McpServers.McpServerSetAuthenticationModeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.McpServers.McpServerSetDescriptionAction SetDescription(Action<commercetools.Sdk.Api.Models.McpServers.McpServerSetDescriptionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.McpServers.McpServerSetDescriptionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.McpServers.McpServerSetJsonOutputFilteringAction SetJsonOutputFiltering(Action<commercetools.Sdk.Api.Models.McpServers.McpServerSetJsonOutputFilteringAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.McpServers.McpServerSetJsonOutputFilteringAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.McpServers.McpServerSetNameAction SetName(Action<commercetools.Sdk.Api.Models.McpServers.McpServerSetNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.McpServers.McpServerSetNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.McpServers.McpServerSetStateAction SetState(Action<commercetools.Sdk.Api.Models.McpServers.McpServerSetStateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.McpServers.McpServerSetStateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.McpServers.McpServerSetToolCustomizationsAction SetToolCustomizations(Action<commercetools.Sdk.Api.Models.McpServers.McpServerSetToolCustomizationsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.McpServers.McpServerSetToolCustomizationsAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.McpServers.McpServerSetToolOutputFormattingAction SetToolOutputFormatting(Action<commercetools.Sdk.Api.Models.McpServers.McpServerSetToolOutputFormattingAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.McpServers.McpServerSetToolOutputFormattingAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.McpServers.McpServerSetToolsAction SetTools(Action<commercetools.Sdk.Api.Models.McpServers.McpServerSetToolsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.McpServers.McpServerSetToolsAction();
            init?.Invoke(t);
            return t;
        }
    }
}
