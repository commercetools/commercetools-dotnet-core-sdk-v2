SHELL := /bin/bash
API_RAML ?= $(RAML_FILE)
IMPORT_RAML ?= $(RAML_FILE)
ML_RAML ?= $(RAML_FILE)
CPUS := `./tools/numcpu.sh`

.PHONY: build build_api_sdk build_import_sdk build_import_sdk build_ml_sdk gen_api_sdk gen_import_sdk gen_ml_sdk

build: codegen_install gen_api_sdk gen_import_sdk gen_ml_sdk verify
build_api_sdk: codegen_install gen_api_sdk verify
build_import_sdk: codegen_install gen_import_sdk verify
build_ml_sdk: codegen_install gen_ml_sdk verify

gen_api_sdk: generate_api
gen_import_sdk: generate_import
gen_ml_sdk: generate_ml

verify:
	dotnet test --verbosity=normal Tests/commercetools.Api.Serialization.Tests --no-build -c Release
	dotnet test --verbosity=normal Tests/commercetools.Api.Tests --no-build -c Release

codegen_install:
	curl -o- -s https://raw.githubusercontent.com/vrapio/rmf-codegen/master/scripts/install.sh | bash

generate_api:
	$(MAKE) -C commercetools.Sdk LIB_NAME="Api" GEN_RAML_FILE=../$(API_RAML) generate_sdk

generate_import:
	$(MAKE) -C commercetools.Sdk LIB_NAME="ImportApi" GEN_RAML_FILE=../$(IMPORT_RAML) generate_sdk

generate_ml:
	$(MAKE) -C commercetools.Sdk LIB_NAME="Ml" PACKAGE_DIR="machine-learning" GEN_RAML_FILE=../$(ML_RAML) generate_sdk
