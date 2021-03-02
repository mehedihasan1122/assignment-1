using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bnak_assignment1
{
    class Address
    {
        private string roadNo;
        private string houseNo;
        private string city;
        private string country;
        public void GetAddress(string r, string h, string c, string con)
        {
            roadNo = r;
            houseNo = h;
            city = c;
            country = con;
        }
        public void ShowAddress()
        {
            Console.WriteLine("Road No: " + roadNo);
            Console.WriteLine("House No: " + houseNo);
            Console.WriteLine("City: " + city);
            Console.WriteLine("Country: " + country);
        }


    }
}
