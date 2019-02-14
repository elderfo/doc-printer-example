using System;

namespace CPrint.Logic.Documents
{

    [Serializable]
    public class PrinterException : Exception
    {
        protected PrinterException() { }
        protected PrinterException(string message) : base(message) { }
        protected PrinterException(string message, Exception inner) : base(message, inner) { }
        protected PrinterException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    [Serializable]
    public class NoPrinterException : PrinterException
    {
        internal NoPrinterException()  : base("No printer was provided.") { }
    }

    [Serializable]
    public class CannotPrintException : PrinterException
    {
        internal CannotPrintException(DocumentType documentType)
            : base($"Specified printer does not support document type: ${documentType}") { }
 
    }
}