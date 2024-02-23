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
	dotnet format commercetools.Sdk --severity warn
