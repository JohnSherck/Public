using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Web.Models
{
    public class PurchaseFlowVM
    {
        public DateTime MovieDate { get; set; }
        public int ShowTimeID { get; set; }
        public string FilmName { get; set; }
        public List<int> ClosedSeats { get; set; }
        public List<int> ChosenSeats { get; set; }
        public string ChosenSeatsAsString { get
            {
                return JsonConvert.SerializeObject(this.ChosenSeats);
            }
            set
            {
                this.ChosenSeats = JsonConvert.DeserializeObject<List<int>>(value);
            }
        }
        public int RegularSeats { get; set; }
        public int KidsSeats { get; set; }
        public int SeniorSeats { get; set; }
        public User CurrentUser { get; set; }
        public decimal RegularTicketPrice { get; set; }
        public decimal Total
        {
            get
            {
                decimal regular = RegularSeats * RegularTicketPrice;
                decimal kids = KidsSeats * KidsTicketPrice;
                decimal senior = SeniorSeats * SeniorTicketPrice;
                decimal total = regular + kids + senior;
                return total;
            }
        }
        public decimal KidsTicketPrice
        {
            get
            {
                return (decimal).6 * RegularTicketPrice;
            }
        }
        public decimal SeniorTicketPrice
        {
            get
            {
                return (decimal).9 * RegularTicketPrice;
            }
        }


        public PurchaseFlowVM()
        {
            this.MovieDate = new DateTime();
            this.ShowTimeID = 0;
            this.FilmName = "";
            this.ClosedSeats = new List<int>();
            this.ChosenSeats = new List<int>();
            this.RegularSeats = 0;
            this.KidsSeats = 0;
            this.SeniorSeats = 0;
            this.CurrentUser = new User();
            this.RegularTicketPrice = (decimal)0.0;

        } 
    }

}