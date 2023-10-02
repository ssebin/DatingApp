using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class AppUser
    {
        // automatically going to be used as PK according to the convention
        // or use [Key]
        public int Id { get; set; }
        public string UserName { get; set;}
    }
}