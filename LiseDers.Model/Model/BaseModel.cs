using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiseDers.Model.Model
{
    public class BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool IsDeleted { get; set; }

    }
}
