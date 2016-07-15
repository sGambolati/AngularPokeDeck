ngPokeDecApp.controller('footerController', function ($scope, DataService) {
    //ToDo: Refacto a un componente.
    this.isOpen = false;
    this.selectedDirection = 'up';
    this.selectedMode = 'md-fling';

    this.availableOptions = [
            
            { name: 'Catch!', url: '/Home/CatchPokemon', icon: '/img/icons/add-plus-button.svg' }, 
            { name: 'Home', url: '/', icon: '/img/icons/home-button.svg' },
    ];
});