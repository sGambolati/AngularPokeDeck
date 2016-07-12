using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ngPokeDeck.Models;
using ngPokeDeck.Repositories;

namespace ngPokeDeck.App_Start
{
    public static class DatabaseSetup
    {
        public static void Setup()
        {
            SetUpPokemons();
        }

        private static void SetUpPokemons()
        {
            var pokemons = new Repository<Pokemon>();

            pokemons.Add(new Pokemon()
            {
                Name = "Bulbasaur",
                Type = ePokemonType.Grass ,
                Number = 1,
                Description = "Bulbasaur can be seen napping in bright sunlight. There is a seed on its back. By soaking up the sun's rays, the seed grows progressively larger."
            });

            pokemons.Add(new Pokemon()
            {
                Name = "Charmander",
                Type =  ePokemonType.Fire,
                Number = 4,
                Description = "The flame that burns at the tip of its tail is an indication of its emotions. The flame wavers when Charmander is enjoying itself. If the Pokémon becomes enraged, the flame burns fiercely."
            });

            pokemons.Add(new Pokemon()
            {
                Name = "Squirtle",
                Type = ePokemonType.Water,
                Number = 7,
                Description = "Squirtle's shell is not merely used for protection. The shell's rounded shape and the grooves on its surface help minimize resistance in water, enabling this Pokémon to swim at high speeds."
            });

            pokemons.Add(new Pokemon()
            {
                Name = "Lucario",
                Type = ePokemonType.Fighting,
                Number = 448,
                Description = "By catching the aura emanating from others, it can read their thoughts and movements."
            });

            pokemons.Add(new Pokemon()
            {
                Name = "Ninetales",
                Type = ePokemonType.Fire,
                Number = 38,
                Description = "Ninetales casts a sinister light from its bright red eyes to gain total control over its foe's mind. This Pokémon is said to live for a thousand years."
            });

            pokemons.Add(new Pokemon()
            {
                Name = "Kyogre",
                Type = ePokemonType.Water,
                Number = 382,
                Description = "Through Primal Reversion and with nature's full power, it will take back its true form. It can summon storms that cause the sea levels to rise."
            });

            pokemons.Add(new Pokemon()
            {
                Name = "Gardevoir",
                Type = ePokemonType.Fairy,
                Number = 282,
                Description = "Gardevoir has the ability to read the future. If it senses impending danger to its Trainer, this Pokémon is said to unleash its psychokinetic energy at full power."
            });
        }
    }
}