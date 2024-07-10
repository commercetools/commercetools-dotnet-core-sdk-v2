using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class AssociateMissingPermissionErrorQueryBuilderDsl
    {
        public AssociateMissingPermissionErrorQueryBuilderDsl()
        {
        }

        public static AssociateMissingPermissionErrorQueryBuilderDsl Of()
        {
            return new AssociateMissingPermissionErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AssociateMissingPermissionErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<AssociateMissingPermissionErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<AssociateMissingPermissionErrorQueryBuilderDsl>(p, AssociateMissingPermissionErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateMissingPermissionErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<AssociateMissingPermissionErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<AssociateMissingPermissionErrorQueryBuilderDsl>(p, AssociateMissingPermissionErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AssociateMissingPermissionErrorQueryBuilderDsl> Associate(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateMissingPermissionErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("associate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl.Of())),
                AssociateMissingPermissionErrorQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<AssociateMissingPermissionErrorQueryBuilderDsl> BusinessUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateMissingPermissionErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("businessUnit"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl.Of())),
                AssociateMissingPermissionErrorQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<AssociateMissingPermissionErrorQueryBuilderDsl> AssociateOnBehalf(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateMissingPermissionErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("associateOnBehalf"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl.Of())),
                AssociateMissingPermissionErrorQueryBuilderDsl.Of);
        }

        public IComparableCollectionPredicateBuilder<AssociateMissingPermissionErrorQueryBuilderDsl, string> Permissions()
        {
            return new ComparableCollectionPredicateBuilder<AssociateMissingPermissionErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("permissions")),
            p => new CombinationQueryPredicate<AssociateMissingPermissionErrorQueryBuilderDsl>(p, AssociateMissingPermissionErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
