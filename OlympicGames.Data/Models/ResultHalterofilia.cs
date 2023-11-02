using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OlympicGames.Data.Models
{
    [Table("ResultHalterofilia")]
    public class ResultHalterofilia : ModelBase
    {
        [Required]
        public string Pais { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Range(0, short.MaxValue)]
        public short Arranque { get; set; }
        [Range(0, short.MaxValue)]
        public short Envion { get; set; }
        [Range(0, short.MaxValue)]
        public short TotalPeso { get; set; }
    }
}
