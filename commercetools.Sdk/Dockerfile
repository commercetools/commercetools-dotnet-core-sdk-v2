# First stage
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /DockerSource

# Copy csproj and restore as distinct layers
COPY . ./src/
WORKDIR /DockerSource/src

RUN dotnet restore

RUN dotnet publish -c release -o /DockerOutput/app --no-restore Examples/commercetools.Api.NewRelicExample

# Final stage
FROM mcr.microsoft.com/dotnet/aspnet:7.0

# Install the agent
RUN apt-get update && apt-get install -y wget ca-certificates gnupg \
&& echo 'deb http://apt.newrelic.com/debian/ newrelic non-free' | tee /etc/apt/sources.list.d/newrelic.list \
&& wget https://download.newrelic.com/548C16BF.gpg \
&& apt-key add 548C16BF.gpg \
&& apt-get update \
&& apt-get install -y newrelic-dotnet-agent \
&& rm -rf /var/lib/apt/lists/*

# Enable the agent
ENV CORECLR_ENABLE_PROFILING=1 \
CORECLR_PROFILER={36032161-FFC0-4B61-B559-F6C5D41BAE5A} \
CORECLR_NEWRELIC_HOME=/usr/local/newrelic-dotnet-agent \
CORECLR_PROFILER_PATH=/usr/local/newrelic-dotnet-agent/libNewRelicProfiler.so \
NEW_RELIC_APP_NAME=commercetools-newrelic-example

WORKDIR /DockerOutput/app
COPY --from=build /DockerOutput/app ./
ENTRYPOINT ["dotnet", "commercetools.Api.NewRelicExample.dll"]