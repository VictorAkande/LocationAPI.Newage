using System.Threading.Tasks;

namespace LocationAPI.Newage.CrossCutting
{
    public interface IBaseResponse<T>
    {
        Task<BaseResponseVm<T>> SuccessMessage(string code, object data);
        Task<BaseResponseVm<T>> InternalServerError();
    }
}
