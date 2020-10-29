SHELL := /bin/bash
PACKAGE_DIR ?= $(LIB_NAME)

generate_sdk:
	rmf-codegen generate -o "commercetools.Sdk.$(LIB_NAME)/Generated" -t CSHARP_CLIENT -b "commercetools.$(LIB_NAME)" $(GEN_RAML_FILE)