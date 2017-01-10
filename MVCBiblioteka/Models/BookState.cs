using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBiblioteka.Models
{
    public class BookState
    {
        
        public int BookStateID { get; set; }
        public string state { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}