using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Extensions
{

    public partial class GoogleCloudFunctionDestinationQueryBuilderDsl
    {
        public GoogleCloudFunctionDestinationQueryBuilderDsl()
        {
        }

        public static GoogleCloudFunctionDestinationQueryBuilderDsl Of()
        {
            return new GoogleCloudFunctionDestinationQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GoogleCloudFunctionDestinationQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<GoogleCloudFunctionDestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<GoogleCloudFunctionDestinationQueryBuilderDsl>(p, GoogleCloudFunctionDestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GoogleCloudFunctionDestinationQueryBuilderDsl, string> Url()
        {
            return new ComparisonPredicateBuilder<GoogleCloudFunctionDestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("url")),
            p => new CombinationQueryPredicate<GoogleCloudFunctionDestinationQueryBuilderDsl>(p, GoogleCloudFunctionDestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
