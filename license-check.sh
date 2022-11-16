#!/usr/bin/env bash

dotnet-project-licenses --input commercetools.Sdk/commercetools.Sdk.sln --projects-filter licenses/filter-projects.json --unique --include-transitive --allowed-license-types licenses/allowed.json --licenseurl-to-license-mappings licenses/license-map.json --json --output-directory licenses --outfile index.json

jq '.' licenses/index.json > licenses/pretty.json
mv licenses/pretty.json licenses/index.json
