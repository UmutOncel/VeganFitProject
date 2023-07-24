using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganFit.Core.BaseEntities;
using VeganFit.Core.Enums;

namespace VeganFit.Entities
{
    /// <summary>
    /// User class'ının property'leri tanımlandı. Ortak property'ler için BaseEntity class'ından kalıtım alındı.
    /// </summary>
    public class User : BaseEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public Role Role { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<Weight> Weights { get; set; }
        public virtual ICollection<Data> Datas { get; set; }
        public User()
        {
            Feedbacks = new HashSet<Feedback>();
            Weights = new HashSet<Weight>();
            Datas = new HashSet<Data>();
        }
    }
}
