using System.Collections.Generic;

namespace NiceTry.Models
{
    public class Repository
    {
        private static List<GuestResponce> responses = new List<GuestResponce>();
        public static IEnumerable<GuestResponce> Responses
        {
            get
            {
                return responses;
            }
        }


        public static void AddResponce(GuestResponce response)
        {
            responses.Add(response);
        }
    }

}
