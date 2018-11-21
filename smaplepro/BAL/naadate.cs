using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace smaplepro.BAL
{
    public class naadate
    {
        public string UserMessage { get; set; }

      


        public naadate(string day)
        {
            WeekDaysList days = (WeekDaysList)Enum.Parse(typeof(WeekDaysList), day);
           
            
            switch (days)
            {
                case WeekDaysList.Monday:
                    UserMessage = "Ram Likes Monday";
                    break;

                case WeekDaysList.Tuesday:
                    UserMessage = "sai Like Tuesday";
                    break;
                case WeekDaysList.Wednesday:
                    UserMessage = "Surya Like Wednesday";
                    break;
                case WeekDaysList.Thursday:
                    UserMessage = "Ravi Like Thursday";
                    break;

                case WeekDaysList.Friday:
                    UserMessage = "Khadar Like Friday";
                    break;

                case WeekDaysList.Saturday:
                    UserMessage = "Vijay Like Satuday";
                    break;
                case WeekDaysList.Sunday:
                    UserMessage = "Ashesh Like Sunday";
                    break;

                default:
                    UserMessage = "sai Like nothing";
                    break;

            }

        }
      


    }
     enum WeekDaysList
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7

    }


}