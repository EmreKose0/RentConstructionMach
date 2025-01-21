using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.ViewModels
{
    public class MachineRequestViewModel
    {
        public int MachineID { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public int LocationID { get; set; }
        public string LocationName { get; set; }
        public string DistrictName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CompanyName { get; set; }
    }
}
