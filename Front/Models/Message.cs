using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ListaCursos.Models
{
    public class Message
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string MessageText { get; set; }
    }
   
}
