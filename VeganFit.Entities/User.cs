using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganFit.Core.BaseEntities;
using VeganFit.Core.Enums;

namespace VeganFit.Entities
{
    public class User : BaseEntity  //baseentity'de create update vb işlemler var. biz kullanıcı update etmiyoruz. oradan kalıtım alması sorun olur mu?
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
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
