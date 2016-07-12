using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ngPokeDeck.Models;
using ngPokeDeck.Repositories;

namespace ngPokeDeck.Controllers
{
    public class PokeDeckController : ApiController
    {
        private Repository<Pokemon> PokemonRepository { get; set; }

        public PokeDeckController()
        {
            this.PokemonRepository = new Repository<Pokemon>();
        }

        public int Post(Pokemon entity)
        {
            if (!ModelState.IsValid)
            {

            }

            var inserted = this.PokemonRepository.Add(entity);
            if (inserted == null)
            {

            }
            return inserted.Id;
        }

        public List<Pokemon> Get()
        {
            return this.PokemonRepository.List().ToList();
        }
    }
}
