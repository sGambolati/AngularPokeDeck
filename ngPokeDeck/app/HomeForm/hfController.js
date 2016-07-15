ngPokeDecApp.controller('hfController', function ($scope, DataService) {
    $scope.pokemonTypes = [];
    $scope.catchedPokemons = [];

    $scope.editingPokemon = {
        Id: 0,
        Number: 0,
        Name: '',
        Type: 5,
        imageUrl: ''
    };

    $scope.$watch('editingPokemon.Number', function (newValue, oldValue) {
        if (newValue === oldValue) {
            return;
        }
        $scope.editingPokemon.imageUrl = $scope.getImageUrl(newValue);
    });

    $scope.getImageUrl = function (_number) {
        var number = _number;
        if (_number < 10)
            number = "0" + number;
        if (_number < 100)
            number = "0" + number;

        return "http://assets.pokemon.com/assets/cms2/img/pokedex/detail/" + number + ".png";
    }

    DataService.getPokemonTypes().then(function (result) {
        $scope.pokemonTypes = result.data;
    }, function (result) {
        debugger;
    });

    DataService.getCatchedPokemons().then(function (result) {
        $scope.catchedPokemons = result.data;
    });

    $scope.mockPost = function () {
        var mockPokemon = { Name: 'Baburro', Type: 1 };

        DataService.addPokemon(mockPokemon).then(function (result) {
            alert("Pokemon inserted: " + result.data)
        });
    };

    $scope.submit = function () {
        DataService.addPokemon($scope.editingPokemon).then(function (result) {
            alert("Pokemon inserted: " + result.data)
        });
    };

})
.config(function ($mdThemingProvider) {
    $mdThemingProvider.theme('dark-blue').backgroundPalette('blue').dark();
});