using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace OlympicGames.Data.Models
{
    public class ModelBase
    {
        [Key]
        [JsonIgnore]
        public int? Id { get; set; }
    }
}
