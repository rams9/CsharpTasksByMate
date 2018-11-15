using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace smaplepro.BAL
{
    public class naadate
    {
        public string UserMessage { get; set; }

        public enum WeekDaysList
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7

        }


        public naadate(string day)
        {
            Enum.TryParse(day, out WeekDaysList days);
            switch (days)
            {
                case WeekDaysList.Monday:
                    UserMessage = "Ram Likes Monday";
                    break;

                case WeekDaysList.Tuesday:
                    UserMessage = "sai Like Tuesday";
                    break;
                case WeekDaysList.Wednesday:
                    UserMessage = "sai Like Wednesday";
                    break;
                case WeekDaysList.Thursday:
                    UserMessage = "sai Like Thursday";
                    break;

                case WeekDaysList.Friday:
                    UserMessage = "sai Like Friday";
                    break;

                case WeekDaysList.Saturday:
                    UserMessage = "sai Like Satuday";
                    break;
                case WeekDaysList.Sunday:
                    UserMessage = "sai Like Sunday";
                    break;

                default:
                    UserMessage = "sai Like nothing";
                    break;

            }

        }



    }

}