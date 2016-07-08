using System;
using CQRSlite.Events;

namespace CQRSCode.ReadModel.Events
{
    public class ItemsCheckedInToInventory : IEvent
    {
        public readonly int Count;
 
        public ItemsCheckedInToInventory(Guid id, int count) 
        {
            AggregateId = id;
            Count = count;
        }

        public Guid AggregateId { get; set; }
        public int Version { get; set; }
        public DateTimeOffset TimeStamp { get; set; }
    }
}