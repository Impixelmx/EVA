using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class AuditData
    {
        public AuditData()
        {
            //CreationDate = evaHelpers.GetDateTimeMexicoCity();
            //ChangeDate = evaHelpers.GetDateTimeMexicoCity();
        }
        [Display(Name = "Estatus")]
        public virtual int Status { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime ChangeDate { get; set; }

        [MaxLength(256)]
        public string CreationUser { get; set; }

        [MaxLength(256)]
        public string ChangeUser { get; set; }
    }
}
