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

ENV DT_PAAS_TOKEN="your PAAS token from Dynatrace (https://docs.dynatrace.com/docs/manage/access-control/access-tokens#paas-token)"
ENV DT_ENVIRONMENT_URL="your environment URL from Dynatrace (https://docs.dynatrace.com/docs/setup-and-configuration/setup-on-container-platforms/docker/set-up-oneagent-on-containers-for-application-only-monitoring#cloud-platforms)"
ENV DT_ONEAGENT_TECHNOLOGY="all"

WORKDIR /DockerOutput/app
COPY --from=build /DockerOutput/app ./

# Expose the port that your application will run on
EXPOSE 8080

RUN apt-get update && \
    apt-get install -y wget unzip && \
    rm -rf /var/lib/apt/lists/*

# ARGs for Dynatrace OneAgent

RUN mkdir -p /opt/dynatrace/oneagent && ARCHIVE=$(mktemp) && wget -O $ARCHIVE "https://$DT_ENVIRONMENT_URL.live.dynatrace.com/api/v1/deployment/installer/agent/unix/paas/latest?Api-Token=$DT_PAAS_TOKEN&flavor=default&arch=arm&include=$DT_ONEAGENT_TECHNOLOGY" && unzip -o -d /opt/dynatrace/oneagent $ARCHIVE && rm -f $ARCHIVE

ENV LD_PRELOAD /opt/dynatrace/oneagent/agent/lib64/liboneagentproc.so

# Set the entry point to start Dynatrace OneAgent
ENTRYPOINT ["dotnet", "commercetools.Api.ApmExample.dll"]