﻿using System.Runtime.Serialization;

namespace Infrastructure
{
    [Serializable]
    internal class GameNotFoundException : Exception
    {
        public GameNotFoundException()
        {
        }

        public GameNotFoundException(string? message) : base(message)
        {
        }

        public GameNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected GameNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}