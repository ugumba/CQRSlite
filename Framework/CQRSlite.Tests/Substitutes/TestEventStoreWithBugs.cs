using System;
using System.Collections.Generic;
using CQRSlite.Events;

namespace CQRSlite.Tests.Substitutes
{
    public class TestEventStoreWithBugs : IEventStore
    {
        public void Save<T>(IEnumerable<IEvent> events)
        {
            
        }

        public IEnumerable<IEvent> Get<T>(Guid aggregateId, int version)
        {
            if (aggregateId == Guid.Empty)
            {
                return new List<IEvent>();
            }

            return new List<IEvent>
            {
                new TestAggregateDidSomething {AggregateId = aggregateId, Version = 3},
                new TestAggregateDidSomething {AggregateId = aggregateId, Version = 2},
                new TestAggregateDidSomeethingElse {AggregateId = aggregateId, Version = 1},
            };
        }
    }
}