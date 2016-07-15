ngPokeDecApp.factory('DataService',
    function ($http) {
        var getPokemonTypes = function () {
            return $http.get('/api/PokemonTypes');
        }
        var addPokemon = function (pokemon) {
            return $http.post('/api/PokeDeck/Post', pokemon);
        }
        var getCatchedPokemons = function () {
            return $http.get('/api/PokeDeck');
        }
        var deletePokemon = function (_id) {
            return $http.delete('/api/PokeDeck/'+_id);
        }

        return {
            getPokemonTypes: getPokemonTypes,
            addPokemon: addPokemon,
            getCatchedPokemons: getCatchedPokemons,
            deletePokemon: deletePokemon
        };
    });