using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ngPokeDeck.Models
{
    public class Pokemon : Entity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        public ePokemonType Type { get; set; }
        public string Description { get; set; }
    }

    public enum ePokemonType
    {
        Normal,
        Fire,
        Fighting,
        Water,
        Flying,
        Grass,
        Poison,
        Electric,
        Ground,
        Psychic,
        Rock,
        Ice,
        Bug,
        Dragon,
        Ghost,
        Dark,
        Steel,
        Fairy, 
        [Description("???")]
        Other
    }
}