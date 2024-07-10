using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLAssociateMissingPermissionErrorQueryBuilderDsl
    {
        public GraphQLAssociateMissingPermissionErrorQueryBuilderDsl()
        {
        }

        public static GraphQLAssociateMissingPermissionErrorQueryBuilderDsl Of()
        {
            return new GraphQLAssociateMissingPermissionErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLAssociateMissingPermissionErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLAssociateMissingPermissionErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLAssociateMissingPermissionErrorQueryBuilderDsl>(p, GraphQLAssociateMissingPermissionErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<GraphQLAssociateMissingPermissionErrorQueryBuilderDsl> Associate(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLAssociateMissingPermissionErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("associate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl.Of())),
                GraphQLAssociateMissingPermissionErrorQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<GraphQLAssociateMissingPermissionErrorQueryBuilderDsl> BusinessUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLAssociateMissingPermissionErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("businessUnit"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl.Of())),
                GraphQLAssociateMissingPermissionErrorQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<GraphQLAssociateMissingPermissionErrorQueryBuilderDsl> AssociateOnBehalf(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLAssociateMissingPermissionErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("associateOnBehalf"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl.Of())),
                GraphQLAssociateMissingPermissionErrorQueryBuilderDsl.Of);
        }

        public IComparableCollectionPredicateBuilder<GraphQLAssociateMissingPermissionErrorQueryBuilderDsl, string> Permissions()
        {
            return new ComparableCollectionPredicateBuilder<GraphQLAssociateMissingPermissionErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("permissions")),
            p => new CombinationQueryPredicate<GraphQLAssociateMissingPermissionErrorQueryBuilderDsl>(p, GraphQLAssociateMissingPermissionErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
