SHELL := /bin/bash
API_RAML ?= $(RAML_FILE)
IMPORT_RAML ?= $(RAML_FILE)
ML_RAML ?= $(RAML_FILE)
HISTORY_RAML ?= $(RAML_FILE)
CPUS := `./tools/numcpu.sh`

.PHONY: build build_api_sdk build_import_sdk build_import_sdk build_history_sdk gen_api_sdk gen_import_sdk gen_history_sdk

build: codegen_install gen_api_sdk gen_import_sdk gen_history_sdk prettify verify
build_api_sdk: codegen_install gen_api_sdk prettify verify
build_import_sdk: codegen_install gen_import_sdk prettify verify
build_history_sdk: codegen_install gen_history_sdk prettify verify

gen_api_sdk: generate_api
gen_import_sdk: generate_import
gen_history_sdk: generate_history

verify:
	dotnet test --verbosity=normal commercetools.Sdk/Tests/commercetools.Api.Serialization.Tests -c Release
	dotnet test --verbosity=normal commercetools.Sdk/Tests/commercetools.Sdk.Api.Tests -c Release
	dotnet test --verbosity=normal commercetools.Sdk/Tests/commercetools.Sdk.HistoryApi.Tests -c Release
	dotnet test --verbosity=normal commercetools.Sdk/Tests/commercetools.Sdk.ImportApi.Tests -c Release

codegen_install:
	curl -o- -s https://raw.githubusercontent.com/vrapio/rmf-codegen/master/scripts/install.sh | bash

generate_api:
	$(MAKE) -C commercetools.Sdk LIB_NAME="Api" GEN_RAML_FILE=../$(API_RAML) generate_sdk_with_predicates

generate_import:
	$(MAKE) -C commercetools.Sdk LIB_NAME="ImportApi" GEN_RAML_FILE=../$(IMPORT_RAML) generate_sdk

generate_history:
	$(MAKE) -C commercetools.Sdk LIB_NAME="HistoryApi" GEN_RAML_FILE=../$(HISTORY_RAML) generate_sdk

prettify:
	dotnet format commercetools.Sdk/commercetools.Base.Abstractions/commercetools.Base.Abstractions.csproj --severity warn
	dotnet format commercetools.Sdk/commercetools.Base.Client/commercetools.Base.Client.csproj --severity warn
	dotnet format commercetools.Sdk/commercetools.Base.Registration/commercetools.Base.Registration.csproj --severity warn
	dotnet format commercetools.Sdk/commercetools.Base.Serialization/commercetools.Base.Serialization.csproj --severity warn
	dotnet format commercetools.Sdk/commercetools.Sdk.Api/commercetools.Sdk.Api.csproj --severity warn
	dotnet format commercetools.Sdk/commercetools.Sdk.GraphQL.Api/commercetools.Sdk.GraphQL.Api.csproj --severity warn
	dotnet format commercetools.Sdk/commercetools.Sdk.HistoryApi/commercetools.Sdk.HistoryApi.csproj --severity warn
	dotnet format commercetools.Sdk/commercetools.Sdk.ImportApi/commercetools.Sdk.ImportApi.csproj --severity warn
	dotnet format commercetools.Sdk/Examples/commercetools.Api.ApmExample/commercetools.Api.ApmExample.csproj --severity warn
	dotnet format commercetools.Sdk/Examples/commercetools.Api.CheckoutApp/commercetools.Api.CheckoutApp.csproj --severity warn
	dotnet format commercetools.Sdk/Examples/commercetools.Api.ConsoleApp/commercetools.Api.ConsoleApp.csproj --severity warn
	dotnet format commercetools.Sdk/Examples/commercetools.Api.NewRelicExample/commercetools.Api.NewRelicExample.csproj --severity warn
	dotnet format commercetools.Sdk/IntegrationTests/commercetools.Api.IntegrationTests/commercetools.Api.IntegrationTests.csproj --severity warn
	dotnet format commercetools.Sdk/IntegrationTests/commercetools.GraphQL.Api.IntegrationTests/commercetools.GraphQL.Api.IntegrationTests.csproj --severity warn
	dotnet format commercetools.Sdk/IntegrationTests/commercetools.ImportApi.IntegrationTests/commercetools.ImportApi.IntegrationTests.csproj --severity warn
	dotnet format commercetools.Sdk/Tests/commercetools.Api.Serialization.Tests/commercetools.Api.Serialization.Tests.csproj --severity warn
	dotnet format commercetools.Sdk/Tests/commercetools.Sdk.Api.Tests/commercetools.Sdk.Api.Tests.csproj --severity warn
	dotnet format commercetools.Sdk/Tests/commercetools.Sdk.HistoryApi.Tests/commercetools.Sdk.HistoryApi.Tests.csproj --severity warn
	dotnet format commercetools.Sdk/Tests/commercetools.Sdk.ImportApi.Tests/commercetools.Sdk.ImportApi.Tests.csproj --severity warn
