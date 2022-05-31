using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKRLib
{

    [Serializable]

    public class TransportException : Exception
    {
        /// <summary>
        /// Конструктор 1.
        /// </summary>
        public TransportException() { }
        /// <summary>
        /// Конструктор 2.
        /// </summary>
        /// <param name="message"></param>
        public TransportException(string message) : base(message) { }
        /// <summary>
        ///  Конструктор 3.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="inner"></param>
        public TransportException(string message, Exception inner) : base(message, inner) { }
        /// <summary>
        /// Конструктор 4.
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected TransportException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
