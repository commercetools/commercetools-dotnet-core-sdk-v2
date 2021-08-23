using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
namespace commercetools.Base.Client.Middlewares
{
    public class UserAgentProvider : IUserAgentProvider
    {
        public UserAgentProvider()
        {
            var executingAssembly = Assembly.GetExecutingAssembly();
            var assemblyVersion = FileVersionInfo.GetVersionInfo(executingAssembly.Location).ProductVersion;

            var attr = (AssemblyFileVersionAttribute)typeof(object).GetTypeInfo().Assembly.GetCustomAttribute(typeof(AssemblyFileVersionAttribute));
            var frameworkName = "dotnet";
            if (RuntimeInformation.FrameworkDescription.StartsWith(".NET Core", StringComparison.OrdinalIgnoreCase))
            {
                frameworkName += "Core";
            }
            else if (RuntimeInformation.FrameworkDescription.StartsWith(".NET Native", StringComparison.OrdinalIgnoreCase))
            {
                frameworkName = "Native";
            }
            else if (RuntimeInformation.FrameworkDescription.StartsWith(".NET Framework", StringComparison.OrdinalIgnoreCase))
            {
                frameworkName = "Framework";
            }

            var osPlatform = string.Empty;
            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                osPlatform = " (" + OSPlatform.OSX + "/" + Environment.OSVersion.Version + ")";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                osPlatform = " (" + OSPlatform.Windows + "/" + Environment.OSVersion.Version + ")";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                osPlatform = " (" + OSPlatform.Linux + "/" + Environment.OSVersion.Version + ")";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Create("FreeBSD")))
            {
                osPlatform = " (FreeBSD/" + Environment.OSVersion.Version + ")";
            }

            this.UserAgent = $"commercetools-sdk-dotnet-v2/{assemblyVersion} {frameworkName}/{attr.Version}{osPlatform}";
        }

        public string UserAgent { get; set; }
    }
}
