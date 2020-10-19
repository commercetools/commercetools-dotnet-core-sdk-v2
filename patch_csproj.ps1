<#
.SYNOPSIS
    .
.DESCRIPTION
    .
.PARAMETER Patch
    Patch matching project files
.PARAMETER File
    The pattern for patching project files
.PARAMETER Version
    The value to set as new version
.PARAMETER PackageVersion
    The value to set as new package version
.PARAMETER AssemblyVersion
    The value to set as new assembly version
.PARAMETER FileVersion
    The value to set as new file version
.PARAMETER InformationalVersion
    The value to set as new informational version
#>

param (
    [Parameter(Mandatory=$false)][switch]$Patch = $false,
    [Parameter(Mandatory=$false)][string]$Version,
    [Parameter(Mandatory=$false)][string]$PackageVersion,
    [Parameter(Mandatory=$false)][string]$AssemblyVersion,
    [Parameter(Mandatory=$false)][string]$FileVersion,
    [Parameter(Mandatory=$false)][string]$InformationalVersion,
    [string]$File = '**\*.csproj'
)

$files = Get-Childitem "$PSScriptRoot\$File" -Recurse

$versionNodes = "Version", "PackageVersion", "AssemblyVersion", "FileVersion", "InformationalVersion"

foreach($patchFile in $files) {
    $xml = [xml](Get-Content $patchFile)
    $fileModified = $false;
    foreach ($versionNode in $versionNodes) {
        $paramValue = Get-Variable -ValueOnly $versionNode;
        if (![string]::IsNullOrWhitespace($paramValue)) {
            $elements = $xml.SelectNodes("//$versionNode")
            foreach ($element in $elements) {
                Write-Output "$patchFile[$versionNode]: $paramValue"
                if ($Patch) {
                    $element.InnerText = $paramValue
                    $fileModified = $true;
                }
            }
        }
    }
    if ($Patch -and $fileModified) {
        $xml.Save($patchFile)
    }
}


