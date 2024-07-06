using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiseDers.Model.Model
{
    public class Ogrenciler : BaseModel
    {
        public int BilisimId { get; set; }
        public int EgitimciId { get; set; }
        public int FenId { get; set; }
        public int MatematikId { get; set; }
        public int SınavId { get; set; }

        public virtual Egitimciler egitimciler { get; set; }
        public virtual Matematik matematik { get; set; }
        public virtual Bilisim bilisim { get; set; }
        public virtual Fen fen { get; set; }

        public ICollection<Sınavlar> sınavlars { get; set; }

    }
}
