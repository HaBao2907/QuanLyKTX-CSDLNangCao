using KTX.Model;
using LibNetCore.Model;

namespace KTX.Interface
{
    public interface IHeThongService
    {
        Task<IEnumerable<NguoiDung>> HeThong_DangNhapHeThong(string userName, string matKhau);
    }
}
