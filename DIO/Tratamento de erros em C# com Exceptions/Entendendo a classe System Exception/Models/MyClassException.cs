using System.Runtime.Serialization;

namespace Entendendo_a_classe_System_Exception.Models
{
  [Serializable]
  public class MyClassException : Exception
  {
    public MyClassException()
    {
    }

    public MyClassException(string? message) : base(message)
    {
    }

    public MyClassException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected MyClassException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    public string? MyProperty { get; set; }
  }
}