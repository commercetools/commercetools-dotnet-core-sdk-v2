using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.AssociateRoles
{

    public partial class AssociateRoleDraftQueryBuilderDsl
    {
        public AssociateRoleDraftQueryBuilderDsl()
        {
        }

        public static AssociateRoleDraftQueryBuilderDsl Of()
        {
            return new AssociateRoleDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AssociateRoleDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<AssociateRoleDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<AssociateRoleDraftQueryBuilderDsl>(p, AssociateRoleDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRoleDraftQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<AssociateRoleDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<AssociateRoleDraftQueryBuilderDsl>(p, AssociateRoleDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRoleDraftQueryBuilderDsl, bool> BuyerAssignable()
        {
            return new ComparisonPredicateBuilder<AssociateRoleDraftQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("buyerAssignable")),
            p => new CombinationQueryPredicate<AssociateRoleDraftQueryBuilderDsl>(p, AssociateRoleDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<AssociateRoleDraftQueryBuilderDsl, string> Permissions()
        {
            return new ComparableCollectionPredicateBuilder<AssociateRoleDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("permissions")),
            p => new CombinationQueryPredicate<AssociateRoleDraftQueryBuilderDsl>(p, AssociateRoleDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AssociateRoleDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateRoleDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                AssociateRoleDraftQueryBuilderDsl.Of);
        }


    }
}
