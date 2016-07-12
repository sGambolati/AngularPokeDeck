ngPokeDecApp.factory('DataService',
    function ($http) {
        var getPokemonTypes = function () {
            return $http.get('/api/PokemonTypes/Get');
        }
        var addPokemon = function (pokemon) {
            return $http.post('/api/PokeDeck/Post', pokemon);
        }
        var getCatchedPokemons = function () {
            return $http.get('/api/PokeDeck/Get');
        }

        return {
            getPokemonTypes: getPokemonTypes,
            addPokemon: addPokemon,
            getCatchedPokemons: getCatchedPokemons
        };
    });