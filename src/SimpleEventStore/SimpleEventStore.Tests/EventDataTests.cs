﻿using System;
using SimpleEventStore.Tests.Events;
using Xunit;

namespace SimpleEventStore.Tests
{
    public class EventDataTests
    {
        private const string StreamId = "TEST-ORDER";

        [Fact]
        public void when_creating_an_instance_the_event_body_must_be_supplied()
        {
            Assert.Throws<ArgumentException>(() => new EventData(null));
        }

        [Fact]
        public void when_creating_an_instance_the_event_body_and_metadata_must_be_supplied()
        {
            Assert.Throws<ArgumentException>(() => new EventData(null, null));
            Assert.Throws<ArgumentException>(() => new EventData(new OrderCreated(StreamId), null));
        }
    }
}
