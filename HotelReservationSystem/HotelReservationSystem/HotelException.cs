using System;
using System.Collections.Generic;
using System.Text;
namespace HotelReservationSystem
{
    public class HotelException : Exception
    {
        public enum ExceptionType
        {
            INVALID_DATE,
            NULL_DATES,
            INVALID_DATE_FORMAT,
        }
        public ExceptionType type;
        public HotelException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
