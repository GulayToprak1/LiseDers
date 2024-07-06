using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiseDers.Model.Model
{
    public class Egitimciler : BaseModel
    {
        public int MatematikId { get; set; }
        public int BilisimId { get; set; }
        public int FenId { get; set; }

        public virtual Fen Fen { get; set; }
        public virtual Matematik Matematik { get; set; }
        public virtual Bilisim Bilisim { get; set; }
    }
}
