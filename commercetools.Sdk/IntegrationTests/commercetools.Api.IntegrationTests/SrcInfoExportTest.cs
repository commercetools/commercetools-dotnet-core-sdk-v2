using System;
using System.IO;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Xunit;

namespace commercetools.Api.IntegrationTests
{
    public class SrcInfoExportTest
    {
        [Fact]
        public void test()
        {
            String programPath = @"/Users/jensschulze/workspace/commercetools-dotnet-sdk-v2/commercetools.Sdk/IntegrationTests/commercetools.Api.IntegrationTests/Categories/CategoriesIntegrationTests.cs";
            String programText = File.ReadAllText(programPath);
            SyntaxTree programTree = CSharpSyntaxTree.ParseText(programText);
            CompilationUnitSyntax root = programTree.GetCompilationUnitRoot();


            var methods = from methodDeclaration in root.DescendantNodes().OfType<MethodDeclarationSyntax>()
                select (
                    ((methodDeclaration.Parent as ClassDeclarationSyntax).Parent as NamespaceDeclarationSyntax).Name.ToFullString(),
                    (methodDeclaration.Parent as ClassDeclarationSyntax).Identifier.ToFullString(),
                    methodDeclaration.Identifier.ToFullString(), methodDeclaration.Body.Statements.ToFullString(),
                    methodDeclaration.GetLocation().GetMappedLineSpan().StartLinePosition.Line.ToString(),
                    methodDeclaration.GetLocation().GetMappedLineSpan().EndLinePosition.Line.ToString()
                );
            
            Console.WriteLine(string.Join("\n", methods));
        }
    }
}