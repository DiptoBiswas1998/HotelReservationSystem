using System;
using System.Collections.Generic;
using System.Text;
namespace HotelReservationSystem
{
    public class CheckDate
    {
        public DateTime[] ValidateAndReturnDates(string[] enteredDates)
        {
            if (enteredDates == null)
            {
                throw new HotelException(HotelException.ExceptionType.NULL_DATES, "No dates given");
            }
            DateTime[] datesValidated = new DateTime[enteredDates.Length];
            for (int i = 0; i < enteredDates.Length; i++)
            {
                DateTime date = ConvertToDate(enteredDates[i]);
                if (date < DateTime.Today)
                {
                    throw new HotelException(HotelException.ExceptionType.INVALID_DATE, "Invalid Date");
                }
                datesValidated[i] = date;
            }
            return datesValidated;
        }
        public DateTime ConvertToDate(string enteredDate)
        {
            try
            {
                DateTime date = DateTime.Parse(enteredDate);
                return date;
            }
            catch (FormatException)
            {
                throw new HotelException(HotelException.ExceptionType.INVALID_DATE_FORMAT, "Invalid Date Format");
            }
        }
    }
}
