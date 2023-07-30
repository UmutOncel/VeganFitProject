using VeganFit.Models.DTOs.UserDtos;
using VeganFit.Models.VMs.UserVms;
using VeganFit.Shared;

namespace VeganFit.Bll.Abstract.IServices
{
    public interface IUserService
    {
        /// <summary>
        /// User tablosu içinde parametre olarak girilen kullanıcı adı ve şifreyi bulan, yoksa hata oluşturan sonucu döndüren metot.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        ResultService<LoginVm> Login(string username, string password);

        /// <summary>
        /// User tablosuna yeni veri ekleyen, eklemeye işleminde hata olursa hata ekleyen olmazsa sonucu döndüren metot.
        /// </summary>
        /// <param name="createVm"></param>
        /// <returns></returns>
        ResultService<UserCreateDto> Create(CreateVm createVm);
    }
}
