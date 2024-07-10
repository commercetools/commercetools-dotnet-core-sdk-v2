using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLExtensionUpdateActionsFailedErrorQueryBuilderDsl
    {
        public GraphQLExtensionUpdateActionsFailedErrorQueryBuilderDsl()
        {
        }

        public static GraphQLExtensionUpdateActionsFailedErrorQueryBuilderDsl Of()
        {
            return new GraphQLExtensionUpdateActionsFailedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLExtensionUpdateActionsFailedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLExtensionUpdateActionsFailedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLExtensionUpdateActionsFailedErrorQueryBuilderDsl>(p, GraphQLExtensionUpdateActionsFailedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<GraphQLExtensionUpdateActionsFailedErrorQueryBuilderDsl> LocalizedMessage(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLExtensionUpdateActionsFailedErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("localizedMessage"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                GraphQLExtensionUpdateActionsFailedErrorQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<GraphQLExtensionUpdateActionsFailedErrorQueryBuilderDsl, string> ExtensionExtraInfo()
        {
            return new ComparisonPredicateBuilder<GraphQLExtensionUpdateActionsFailedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("extensionExtraInfo")),
            p => new CombinationQueryPredicate<GraphQLExtensionUpdateActionsFailedErrorQueryBuilderDsl>(p, GraphQLExtensionUpdateActionsFailedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<GraphQLExtensionUpdateActionsFailedErrorQueryBuilderDsl> ExtensionErrors(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.ExtensionErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.ExtensionErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLExtensionUpdateActionsFailedErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("extensionErrors"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.ExtensionErrorQueryBuilderDsl.Of())),
                GraphQLExtensionUpdateActionsFailedErrorQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<GraphQLExtensionUpdateActionsFailedErrorQueryBuilderDsl> ExtensionErrors()
        {
            return new CollectionPredicateBuilder<GraphQLExtensionUpdateActionsFailedErrorQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("extensionErrors")),
                    p => new CombinationQueryPredicate<GraphQLExtensionUpdateActionsFailedErrorQueryBuilderDsl>(p, GraphQLExtensionUpdateActionsFailedErrorQueryBuilderDsl.Of));
        }

    }
}
