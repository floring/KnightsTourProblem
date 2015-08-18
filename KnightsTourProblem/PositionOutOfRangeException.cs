using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KnightsTourProblem
{
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
