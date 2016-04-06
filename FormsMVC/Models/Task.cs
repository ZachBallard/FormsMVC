using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormsMVC
{
    public class Task
    {
        [Required]
        public virtual string User { get; set; }
        public virtual string TaskDescription { get; set; }
        public virtual bool IsComplete { get; set; }

    }
}