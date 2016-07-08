using CQRSlite.Messages;
using System;

namespace CQRSlite.Events
{
    public interface IEvent : IMessage
    {
        Guid AggregateId { get; set; }
        int Version { get; set; }
        DateTimeOffset TimeStamp { get; set; }
    }
}

