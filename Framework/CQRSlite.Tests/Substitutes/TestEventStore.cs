using System;
using System.Collections.Generic;
using System.Linq;
using CQRSlite.Events;

namespace CQRSlite.Tests.Substitutes
{
    public class TestEventStore : IEventStore
    {
        private readonly Guid _emptyGuid;

        public TestEventStore()
        {
            _emptyGuid = Guid.NewGuid();
            SavedEvents = new List<IEvent>();
        }

        public IEnumerable<IEvent> Get<T>(Guid aggregateId, int version)
        {
            if (aggregateId == _emptyGuid || aggregateId == Guid.Empty)
            {
                return new List<IEvent>();
            }

            return new List<IEvent>
                {
                    new TestAggregateDidSomething {AggregateId = aggregateId, Version = 1},
                    new TestAggregateDidSomeethingElse {AggregateId = aggregateId, Version = 2},
                    new TestAggregateDidSomething {AggregateId = aggregateId, Version = 3},
                }.Where(x => x.Version > version);
        }

        public void Save<T>(IEnumerable<IEvent> events)
        {
            SavedEvents.AddRange(events);
        }

        private List<IEvent> SavedEvents { get; }
    }
}
