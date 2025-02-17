﻿using Orleans.Storage;
using System;
using System.Runtime.Serialization;

namespace Orleans.TestingHost
{
    [Serializable]
    public class RandomlyInjectedStorageException : Exception
    {
        public RandomlyInjectedStorageException() : base("injected fault") { }

        protected RandomlyInjectedStorageException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }

    [Serializable]
    public class RandomlyInjectedInconsistentStateException : InconsistentStateException
    {
        public RandomlyInjectedInconsistentStateException() : base("injected fault") { }

        protected RandomlyInjectedInconsistentStateException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
