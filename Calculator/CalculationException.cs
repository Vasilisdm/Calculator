using System;

namespace Calculator
{
    public class CalculationException : Exception
    {
        private static readonly string DefaultMessage = "An error occurred during calculation";

        /// <summary>
        /// Create a new <see cref="CalculationException"> with a predefined message
        /// </summary>
        public CalculationException() : base(DefaultMessage)
        {
        }

        /// <summary>
        /// Creates a new <see cref="CalculationException"> with a user-supplied message
        /// </summary>
        /// <param name="message"></param>
        public CalculationException(string message) : base(message)
        {
        }

        /// <summary>
        /// Creates a new <see cref="CalculationException"> with a default message and a wrapped inner exception
        /// </summary>
        /// <param name="innerException"></param>
        public CalculationException(Exception innerException) : base(DefaultMessage,innerException)
        { 
        }

        /// <summary>
        /// Creates ane <see cref="CalculationException"> with a user-supplied message and a wrapped inner exception
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public CalculationException(string message, Exception innerException) : base(message, innerException)
        { 
        }
    }
}
