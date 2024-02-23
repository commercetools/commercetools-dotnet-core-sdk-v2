using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Extensions
{

    public partial class ExtensionDestinationQueryBuilderDsl
    {
        public ExtensionDestinationQueryBuilderDsl()
        {
        }

        public static ExtensionDestinationQueryBuilderDsl Of()
        {
            return new ExtensionDestinationQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ExtensionDestinationQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ExtensionDestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ExtensionDestinationQueryBuilderDsl>(p, ExtensionDestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<ExtensionDestinationQueryBuilderDsl> AsAwsLambda(
            Func<commercetools.Sdk.Api.Predicates.Query.Extensions.AWSLambdaDestinationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Extensions.AWSLambdaDestinationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ExtensionDestinationQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Extensions.AWSLambdaDestinationQueryBuilderDsl.Of()),
                ExtensionDestinationQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ExtensionDestinationQueryBuilderDsl> AsGoogleCloudFunction(
            Func<commercetools.Sdk.Api.Predicates.Query.Extensions.GoogleCloudFunctionDestinationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Extensions.GoogleCloudFunctionDestinationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ExtensionDestinationQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Extensions.GoogleCloudFunctionDestinationQueryBuilderDsl.Of()),
                ExtensionDestinationQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ExtensionDestinationQueryBuilderDsl> AsHttp(
            Func<commercetools.Sdk.Api.Predicates.Query.Extensions.HttpDestinationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Extensions.HttpDestinationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ExtensionDestinationQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Extensions.HttpDestinationQueryBuilderDsl.Of()),
                ExtensionDestinationQueryBuilderDsl.Of);
        }
    }
}
