using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Models
{
    public class Park
    {
        public int Park_Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime Establish_Date { get; set; }
        public int Area { get; set; }
        public int Visitors { get; set; }
        public String Description { get; set; }

        //public override string ToString()
        //{
        //    return CityId.ToString().PadRight(6) + Name.PadRight(30) + District.PadRight(30) + Population.ToString("N0").PadRight(10);
        //}
    }
}
