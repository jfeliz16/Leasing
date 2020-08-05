using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JETech.Leasing.Web.Data.Entities
{
    public class Lessee
    {
        public int Id { get; set; }

        public User User { get; set; }
    }

}

