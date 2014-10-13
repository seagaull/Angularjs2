var mainModule = angular.module("mainModule", ['ngRoute'])
    .config(function($routeProvider, $locationProvider) {
        $routeProvider.when('/AngularJS.Practice/Home/Users',
            {
                templateUrl: '/AngularJS.Practice/Templaets/Users.html',
                controller: 'users-controller'
            });
        $routeProvider.when('/AngularJS.Practice/Home/Jobs', {
            templateUrl: '/AngularJS.Practice/Templaets/Jobs.html',
            controller: 'jobs-controller'
        });
        $locationProvider.html5Mode(true);

});
