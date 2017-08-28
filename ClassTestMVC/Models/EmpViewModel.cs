using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassTestMVC.Models
{
    public class EmpViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool MaritalStatus { get; set; }
        public int SteId { get; set; }
        public int CityId { get; set; }

        public IEnumerable<City> City { get; set; }
        public IEnumerable<Ste> Ste { get; set; }
        public Emp Employee { get; set; }




    }
}