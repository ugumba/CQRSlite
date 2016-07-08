﻿using System;
using CQRSlite.Events;

namespace CQRSCode.ReadModel.Events
{
    public class InventoryItemRenamed : IEvent
    {
        public readonly string NewName;
 
        public InventoryItemRenamed(Guid id, string newName)
        {
            AggregateId = id;
            NewName = newName;
        }

        public Guid AggregateId { get; set; }
        public int Version { get; set; }
        public DateTimeOffset TimeStamp { get; set; }
    }
}