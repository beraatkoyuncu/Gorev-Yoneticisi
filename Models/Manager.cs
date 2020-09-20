using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    public class Manager
    {
        public int ID { get; set; }
        [Display(Name = "Aktivite İsmi")]
        public string ActivityName { get; set; }
        [Display(Name = "Aktivite Tarihi")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Aktivite Saati")]
        [DataType(DataType.Time)]
        public DateTime ReleaseTime { get; set; }
        [Display(Name = "Aktivite Açıklaması")]
        public string ActivityExplanation { get; set; }

    }
}
