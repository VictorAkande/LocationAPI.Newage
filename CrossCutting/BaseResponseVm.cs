namespace LocationAPI.Newage.CrossCutting
{
    public class BaseResponseVm<T>
    {
        public string code { get; set; }
        public bool Successful { get; set; } 

        public T data { get; set; } = default(T);
    }
}
