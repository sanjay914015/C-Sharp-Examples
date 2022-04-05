using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication5.Models
{
    public class Movies ///POCO Class= Plan old CLR object
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }  //Data annitation

        public string Genre { get; set; }

        public decimal Price { get; set; }

    
    }
}
