SHELL := /bin/bash
PACKAGE_DIR ?= $(LIB_NAME)

generate_sdk: generate_sdk_main generate_sdk_test

generate_sdk_main:
	rmf-codegen generate -o "commercetools.Sdk.$(LIB_NAME)/Generated" -t CSHARP_CLIENT -b "commercetools.Sdk.$(LIB_NAME)" $(GEN_RAML_FILE)

generate_sdk_test:
	rmf-codegen generate -o "Tests/commercetools.Sdk.$(LIB_NAME).Tests/Generated" -t CSHARP_TEST -b "commercetools.Sdk.$(LIB_NAME)" $(GEN_RAML_FILE)