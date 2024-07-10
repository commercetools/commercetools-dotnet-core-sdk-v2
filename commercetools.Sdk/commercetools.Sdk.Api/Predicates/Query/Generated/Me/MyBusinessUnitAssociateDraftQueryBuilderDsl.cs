using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyBusinessUnitAssociateDraftQueryBuilderDsl
    {
        public MyBusinessUnitAssociateDraftQueryBuilderDsl()
        {
        }

        public static MyBusinessUnitAssociateDraftQueryBuilderDsl Of()
        {
            return new MyBusinessUnitAssociateDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyBusinessUnitAssociateDraftQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitAssociateDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<MyBusinessUnitAssociateDraftQueryBuilderDsl>(p, MyBusinessUnitAssociateDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyBusinessUnitAssociateDraftQueryBuilderDsl> Customer(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyBusinessUnitAssociateDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customer"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerDraftQueryBuilderDsl.Of())),
                MyBusinessUnitAssociateDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<MyBusinessUnitAssociateDraftQueryBuilderDsl> AssociateRoleAssignments(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateRoleAssignmentDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateRoleAssignmentDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyBusinessUnitAssociateDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("associateRoleAssignments"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateRoleAssignmentDraftQueryBuilderDsl.Of())),
                MyBusinessUnitAssociateDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<MyBusinessUnitAssociateDraftQueryBuilderDsl> AssociateRoleAssignments()
        {
            return new CollectionPredicateBuilder<MyBusinessUnitAssociateDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("associateRoleAssignments")),
                    p => new CombinationQueryPredicate<MyBusinessUnitAssociateDraftQueryBuilderDsl>(p, MyBusinessUnitAssociateDraftQueryBuilderDsl.Of));
        }

    }
}
