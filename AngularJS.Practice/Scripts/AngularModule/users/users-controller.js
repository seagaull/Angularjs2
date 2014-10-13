mainModule.controller('users-controller', function ($scope, usersRerpository) {
    usersRerpository.get().then(function (users) { $scope.users = users;});
    

});