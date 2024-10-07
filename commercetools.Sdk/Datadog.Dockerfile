# First stage
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /DockerSource

# Copy csproj and restore as distinct layers
COPY . ./src/
WORKDIR /DockerSource/src

RUN dotnet restore

RUN dotnet publish -c release -o /DockerOutput/app --no-restore Examples/commercetools.Api.ApmExample

# Final stage
FROM mcr.microsoft.com/dotnet/aspnet:7.0

WORKDIR /DockerOutput/app
COPY --from=build /DockerOutput/app ./

# Expose the port that your application will run on
EXPOSE 8080

LABEL "com.datadoghq.ad.logs"='[{"source": "dotnet", "service": "apmapp"}]'

RUN apt-get update && \
    apt-get install -y curl && \
    rm -rf /var/lib/apt/lists/*

ENV TRACER_ARCH=arm64
# Download and install the Tracer
RUN mkdir -p /opt/datadog \
    && mkdir -p /var/log/datadog \
    && TRACER_VERSION=$(curl -s https://api.github.com/repos/DataDog/dd-trace-dotnet/releases/latest | grep tag_name | cut -d '"' -f 4 | cut -c2-) \
    && curl -LO https://github.com/DataDog/dd-trace-dotnet/releases/download/v${TRACER_VERSION}/datadog-dotnet-apm_${TRACER_VERSION}_${TRACER_ARCH}.deb \
    && dpkg -i ./datadog-dotnet-apm_${TRACER_VERSION}_${TRACER_ARCH}.deb \
    && rm ./datadog-dotnet-apm_${TRACER_VERSION}_${TRACER_ARCH}.deb

# Enable the tracer
ENV CORECLR_ENABLE_PROFILING=1
ENV CORECLR_PROFILER={846F5F1C-F9AE-4B07-969E-05C26BC060D8}
ENV CORECLR_PROFILER_PATH=/opt/datadog/Datadog.Trace.ClrProfiler.Native.so
ENV DD_DOTNET_TRACER_HOME=/opt/datadog

# For containers
ENV DD_AGENT_HOST=agent
ENV DD_TRACE_AGENT_PORT=8126

# Set the entry point to start application
ENTRYPOINT ["dotnet", "commercetools.Api.ApmExample.dll"]