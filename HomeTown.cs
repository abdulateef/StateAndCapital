using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateAndCapitalAPI
{
    class HomeTown
    {
        public string state { get; set; }
        public string capital { get; set; }

        public static void OrderByStateThenCapital()
        {
            List<HomeTown> hometowns = new List<HomeTown>(){
                new HomeTown(){state="Abia" , capital="Umuahia"},
                new HomeTown(){state="Adamawa" , capital="Yola"},
                new HomeTown(){state="Akwa Ibom" , capital="Uyo"},
                new HomeTown(){state="Anambra" , capital="Awka"},
                new HomeTown(){state="Bauchi" , capital="Bauchi"},
                new HomeTown(){state="Bayelsa" , capital="Yenegoa"},
                new HomeTown(){state="Benue" , capital="Makurdi"},
                new HomeTown(){state="Borno" , capital="Maiduguri"},
                new HomeTown(){state="Cross River" , capital="Calabar"},
                new HomeTown(){state="Delta" , capital="Asaba"},
                new HomeTown(){state="Ebonyi" , capital="Abakaliki"},
                new HomeTown(){state="Edo" , capital="Benine City"},
                new HomeTown(){state="Ekiti" , capital="Ado-Ekiti"},
                new HomeTown(){state="Enugu" , capital="Enugu"},
                new HomeTown(){state="Gombe" , capital="Gombe"},
                new HomeTown(){state="Imo" , capital="Owerri"},
                new HomeTown(){state="Jigawa" , capital="Dutse"},
                new HomeTown(){state="Kaduna" , capital="Kaduna"},
                new HomeTown(){state="Kano" , capital="Kano"},
                new HomeTown(){state="Katsina" , capital="Katsina"},
                new HomeTown(){state="kebbi" , capital="Birni Kebbi"},
                new HomeTown(){state="Kogi" , capital="LOkoja"},
                new HomeTown(){state="Kwara", capital="Ilorin"},
                new HomeTown(){state="Lagas", capital="Ikeja"},
                new HomeTown(){state="Nassarawa", capital="Lafia"},
                new HomeTown(){state="Niger", capital="Minna"},
                new HomeTown(){state="Ogun", capital="Abeokuta"},
                new HomeTown(){state="Ondo", capital="Akure"},
                new HomeTown(){state="Osun", capital="Oshogbo"},
                new HomeTown(){state="Oyo", capital="Ibadan"},
                new HomeTown(){state="Plateau", capital="Jos"},
                new HomeTown(){state="River", capital="Port-Harcout"},
                new HomeTown(){state="Sokoto", capital="Sokoto"},
                new HomeTown(){state="Taraba", capital="Jalingo"},
                new HomeTown(){state="Yobe", capital="Damaturu"},
                new HomeTown(){state="Zamfara", capital="Gasau"},
                new HomeTown(){state="FCT", capital="Abuja"},
            };

            var orderedHometowns = from stateAndCapital in hometowns
                                   orderby stateAndCapital.state ascending, stateAndCapital.capital ascending
                                   select stateAndCapital;
            foreach(HomeTown item in orderedHometowns)
            {
                //Console.WriteLine(item.state + " : " + item.capital);
              
            }

        }
    }
}
