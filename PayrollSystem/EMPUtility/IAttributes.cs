using System;

namespace EMPUtility
{
    public interface IAttributes
    {
      string  message { get; set; }

        bool IsValid(object item);
    }
}
