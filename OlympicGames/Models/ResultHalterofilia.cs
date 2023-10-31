namespace OlympicGames.Models
{
    public class ResultHalterofilia
    {
        public string Pais { get; set; }
        public string Nombre { get; set; }
        public int Arranque { get; set; }
        public int Envion { get; set; }
        public int TotalPeso
        {
            get { return Arranque + Envion; }
        }
    }
}
