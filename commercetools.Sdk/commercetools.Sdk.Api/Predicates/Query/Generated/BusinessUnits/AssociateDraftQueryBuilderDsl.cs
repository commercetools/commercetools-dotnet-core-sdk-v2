using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class AssociateDraftQueryBuilderDsl
    {
        public AssociateDraftQueryBuilderDsl()
        {
        }

        public static AssociateDraftQueryBuilderDsl Of()
        {
            return new AssociateDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<AssociateDraftQueryBuilderDsl> AssociateRoleAssignments(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateRoleAssignmentDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateRoleAssignmentDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("associateRoleAssignments"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateRoleAssignmentDraftQueryBuilderDsl.Of())),
                AssociateDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<AssociateDraftQueryBuilderDsl> AssociateRoleAssignments()
        {
            return new CollectionPredicateBuilder<AssociateDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("associateRoleAssignments")),
                    p => new CombinationQueryPredicate<AssociateDraftQueryBuilderDsl>(p, AssociateDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<AssociateDraftQueryBuilderDsl> Customer(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customer"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl.Of())),
                AssociateDraftQueryBuilderDsl.Of);
        }


    }
}
