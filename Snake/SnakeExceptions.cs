using System;

namespace Snake
{

    [Serializable]
    public class SnakeHitBorderException : Exception
    {
        public SnakeHitBorderException() { }
        public SnakeHitBorderException(string message) : base(message) { }
        public SnakeHitBorderException(string message, Exception inner) : base(message, inner) { }
        protected SnakeHitBorderException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }


    [Serializable]
    public class SnakeBiteTailException : Exception
    {
        public SnakeBiteTailException() { }
        public SnakeBiteTailException(string message) : base(message) { }
        public SnakeBiteTailException(string message, Exception inner) : base(message, inner) { }
        protected SnakeBiteTailException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
