using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Predicates.Query
{
    public class CollectionQueryPredicate : ICollectionPredicate<IQueryPredicate>, IQueryPredicate
    {
        private readonly IEnumerable<IQueryPredicate> _predicates;

        public CollectionQueryPredicate(IEnumerable<IQueryPredicate> predicates) {
            this._predicates = predicates;
        }

        public CollectionQueryPredicate() {
            this._predicates = new List<IQueryPredicate>();
        }

        public IEnumerable<IQueryPredicate> Predicates() {
            return _predicates;
        }

        public CollectionQueryPredicate Predicates(IEnumerable<IQueryPredicate> predicates) {
            return new CollectionQueryPredicate(new List<IQueryPredicate>(predicates));
        }

        public CollectionQueryPredicate AddPredicate(IQueryPredicate predicate) {
            IList<IQueryPredicate> predicates = new List<IQueryPredicate>(this._predicates);
            predicates.Add(predicate);
            return new CollectionQueryPredicate(predicates);
        }

        public string Render() {
            return string.Join(", ", Predicates().Select(predicate => predicate.Render()));
        }
        
        public static CollectionQueryPredicate Of()
        {
            return new CollectionQueryPredicate();
        }
    }
}