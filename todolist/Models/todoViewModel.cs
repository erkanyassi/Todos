using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace todolist.Models
{
    public class todoViewModel
    {
       // public int todoId { get; set; }

        [Required(ErrorMessage = "Enter Todo Content")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Enter Todo Content")]
        public string Content { get; set; }

        public IEnumerable<todo> todo { get; set; }
        [Required(ErrorMessage = "Enter date")]
        public DateTime Date { get; set; }

    }
}