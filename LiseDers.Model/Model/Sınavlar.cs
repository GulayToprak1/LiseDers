using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiseDers.Model.Model
{
    public class Sınavlar : BaseModel
    {
        public int OgrenciId { get; set; }
        public int MatematikId { get; set; }
        public int FenId { get; set; }
        public int BilisimId { get; set; }

        public ICollection<Ogrenciler> Ogrenciler { get; set; }
        public ICollection<Matematik> Matematik { get; set; }
        public ICollection<Fen> Fen { get; set; }
        public ICollection<Bilisim> Bilisim { get; set; }

    }
}
