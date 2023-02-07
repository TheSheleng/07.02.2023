using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City
{
    public class City
    {
        string name;
        string country;
        int heading;
        int telecode;
        string[] areas;

        public string Name { get => name; set => name = value; }
        public string Country { get => country; set => country = value; }
        public int Heading
        {
            get => heading;
            set
            {
                if (value < 0)
                    throw new Exception("Invalid Value for Heading");
                heading = value;
            }
        }
        public int Telecone
        {
            get => telecode;
            set
            {
                if (value < 100 || value > 999) 
                    throw new Exception("Invalid Value for Telephone");
                telecode = value;
            }
        }

        public override string ToString()
        {
            var res = new StringBuilder();

            res.AppendLine($"Name: {name}");
            res.AppendLine($"Country: {country}");
            res.AppendLine($"Heading: {heading}");
            res.AppendLine($"Telephone: {telecode}");

            res.AppendLine("Areas: ");
            foreach ( var item in areas) res.AppendLine(item);

            return res.ToString();
        }
    }
}
