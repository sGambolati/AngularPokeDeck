using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ngPokeDeck.Models;

namespace ngPokeDeck.Controllers
{
    public class PokemonTypesController : ApiController
    {
        public IList<KeyValuePair<int, string>> Get()
        {
            IList<KeyValuePair<int, string>> result = new List<KeyValuePair<int, string>>();

            var values = Enum.GetValues(typeof(ePokemonType));
            foreach (var pokemonType in values)
            {
                result.Add(new KeyValuePair<int, string>((int)pokemonType, Enum.GetName(typeof(ePokemonType), pokemonType)));
            }

            return result;
        }
    }
}
