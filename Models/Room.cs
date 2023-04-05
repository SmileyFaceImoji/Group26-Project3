using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GRP26Project.Models
{
    public class Room
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoomID { get; set; }
        public string ImageURL { get; set; }
        public string RoomType { get; set; }
        public double PricePerNight { get; set; }
        public bool Available { get; set; }

    }
}