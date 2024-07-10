using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLExtensionBadResponseErrorQueryBuilderDsl
    {
        public GraphQLExtensionBadResponseErrorQueryBuilderDsl()
        {
        }

        public static GraphQLExtensionBadResponseErrorQueryBuilderDsl Of()
        {
            return new GraphQLExtensionBadResponseErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLExtensionBadResponseErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLExtensionBadResponseErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLExtensionBadResponseErrorQueryBuilderDsl>(p, GraphQLExtensionBadResponseErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<GraphQLExtensionBadResponseErrorQueryBuilderDsl> LocalizedMessage(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLExtensionBadResponseErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("localizedMessage"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                GraphQLExtensionBadResponseErrorQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<GraphQLExtensionBadResponseErrorQueryBuilderDsl, string> ExtensionExtraInfo()
        {
            return new ComparisonPredicateBuilder<GraphQLExtensionBadResponseErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("extensionExtraInfo")),
            p => new CombinationQueryPredicate<GraphQLExtensionBadResponseErrorQueryBuilderDsl>(p, GraphQLExtensionBadResponseErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<GraphQLExtensionBadResponseErrorQueryBuilderDsl> ExtensionErrors(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.ExtensionErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.ExtensionErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLExtensionBadResponseErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("extensionErrors"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.ExtensionErrorQueryBuilderDsl.Of())),
                GraphQLExtensionBadResponseErrorQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<GraphQLExtensionBadResponseErrorQueryBuilderDsl> ExtensionErrors()
        {
            return new CollectionPredicateBuilder<GraphQLExtensionBadResponseErrorQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("extensionErrors")),
                    p => new CombinationQueryPredicate<GraphQLExtensionBadResponseErrorQueryBuilderDsl>(p, GraphQLExtensionBadResponseErrorQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<GraphQLExtensionBadResponseErrorQueryBuilderDsl, string> ExtensionBody()
        {
            return new ComparisonPredicateBuilder<GraphQLExtensionBadResponseErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("extensionBody")),
            p => new CombinationQueryPredicate<GraphQLExtensionBadResponseErrorQueryBuilderDsl>(p, GraphQLExtensionBadResponseErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLExtensionBadResponseErrorQueryBuilderDsl, long> ExtensionStatusCode()
        {
            return new ComparisonPredicateBuilder<GraphQLExtensionBadResponseErrorQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("extensionStatusCode")),
            p => new CombinationQueryPredicate<GraphQLExtensionBadResponseErrorQueryBuilderDsl>(p, GraphQLExtensionBadResponseErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLExtensionBadResponseErrorQueryBuilderDsl, string> ExtensionId()
        {
            return new ComparisonPredicateBuilder<GraphQLExtensionBadResponseErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("extensionId")),
            p => new CombinationQueryPredicate<GraphQLExtensionBadResponseErrorQueryBuilderDsl>(p, GraphQLExtensionBadResponseErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLExtensionBadResponseErrorQueryBuilderDsl, string> ExtensionKey()
        {
            return new ComparisonPredicateBuilder<GraphQLExtensionBadResponseErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("extensionKey")),
            p => new CombinationQueryPredicate<GraphQLExtensionBadResponseErrorQueryBuilderDsl>(p, GraphQLExtensionBadResponseErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
