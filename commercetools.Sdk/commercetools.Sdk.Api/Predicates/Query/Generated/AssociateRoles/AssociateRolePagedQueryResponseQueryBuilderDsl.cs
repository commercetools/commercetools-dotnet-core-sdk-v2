using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.AssociateRoles
{

    public partial class AssociateRolePagedQueryResponseQueryBuilderDsl
    {
        public AssociateRolePagedQueryResponseQueryBuilderDsl()
        {
        }

        public static AssociateRolePagedQueryResponseQueryBuilderDsl Of()
        {
            return new AssociateRolePagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AssociateRolePagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<AssociateRolePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<AssociateRolePagedQueryResponseQueryBuilderDsl>(p, AssociateRolePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRolePagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<AssociateRolePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<AssociateRolePagedQueryResponseQueryBuilderDsl>(p, AssociateRolePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRolePagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<AssociateRolePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<AssociateRolePagedQueryResponseQueryBuilderDsl>(p, AssociateRolePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRolePagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<AssociateRolePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<AssociateRolePagedQueryResponseQueryBuilderDsl>(p, AssociateRolePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AssociateRolePagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateRolePagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleQueryBuilderDsl.Of())),
                AssociateRolePagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<AssociateRolePagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<AssociateRolePagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<AssociateRolePagedQueryResponseQueryBuilderDsl>(p, AssociateRolePagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
