using System;
using System.Runtime.Serialization;

namespace KnightsTourProblem
{
    /// <summary>
    /// Implements PositionOutOfRangeException.
    /// Throws exception if a starting position from which to start the tour goes beyond the board.
    /// </summary>
    [Serializable()]
    class PositionOutOfRangeException : SystemException
    {
        public PositionOutOfRangeException()
        {
            // Add any type-specific logic, and supply the default message.
        }

        public PositionOutOfRangeException(string message)
            : base(message)
        {
            // Add any type-specific logic.
        }

        public PositionOutOfRangeException(string message, Exception innerException)
            : base(message, innerException)
        {
            // Add any type-specific logic for inner exceptions.
        }

        protected PositionOutOfRangeException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            // Implement type-specific serialization constructor logic.
        }
    }
}
