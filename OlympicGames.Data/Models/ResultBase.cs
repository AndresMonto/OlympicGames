namespace OlympicGames.Data.Models
{
    public class ResultBase<T> where T : ModelBase
    {
        public List<T> ResultList { get; set; }
        public T Result { get; set; }
        public StatusBase StatusBase { get; set; }

        public ResultBase() {
            ResultList = new();
            StatusBase = new();
            Result = Activator.CreateInstance<T>();
        }
    }
}
