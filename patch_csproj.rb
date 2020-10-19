#!/usr/bin/env ruby

require 'rexml/document'
require 'optparse'

include REXML

params = {}
OptionParser.new do |opts|
    opts.on("-p", "--patch", "Patch project files") { |v| params[:patch] = true }
    opts.on("--version VERSION", String, "Version to set") { |v| params[:Version] = v }
    opts.on("--package_version VERSION", String, "Package version to set") { |v| params[:PackageVersion] = v }
    opts.on("--assembly_version VERSION", String, "Assembly version to set") { |v| params[:AssemblyVersion] = v }
    opts.on("--file_version VERSION", String, "File version to set") { |v| params[:FileVersion] = v }
    opts.on("--informational_version VERSION", String, "Informational version to set") { |v| params[:InformationalVersion] = v }
end.parse!
files = ARGV

versionNodes = [
    "Version",
    "PackageVersion",
    "AssemblyVersion",
    "FileVersion",
    "InformationalVersion"
]

files = ["**/*.csproj"] if files.empty?
files.each do |filePattern|
    Dir.glob(filePattern).each do |projFile|
        xmlFile = File.new(projFile)
        xmlDoc = Document.new(xmlFile)
        xmlDoc.context[:attribute_quote] = :quote

        fileModified = false
        for versionNode in versionNodes do
            if params[versionNode.to_sym]
                XPath.each(xmlDoc, "//" + versionNode) do|node|
                    p "#{projFile}[#{versionNode}]: #{params[versionNode.to_sym]}"
                    if params[:patch]
                        node.text = params[versionNode.to_sym]
                        fileModified = true
                    end
                end
            end
        end

        if params[:patch] && fileModified
            xmlDoc.write(File.open(projFile, "w"))
        end
    end
end
