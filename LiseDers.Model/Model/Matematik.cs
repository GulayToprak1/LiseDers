using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiseDers.Model.Model
{
    public class Matematik : BaseModel
    {
        public int OgrenciId { get; set; }
        public int EgitimciId { get; set; }
        public int SınavId { get; set; }

        public ICollection<Ogrenciler> Ogrenciler { get; set; }
        public ICollection<Egitimciler> Egitimciler { get; set; }
        public ICollection<Sınavlar> Sınavlar { get; set; }

    }
}
