using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganFit.Core.Enums;

namespace VeganFit.Core.BaseEntities
{
    /// <summary>
    /// Kullanılan tüm entity'lerin ortak property'leri için class açıldı.
    /// </summary>
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public State State { get; set; }
        //State enum'ındaki Deleted => gevşek silme (Veri database'den kaldırılmıyor, silindi olarak işaretleniyor)
    }
}
