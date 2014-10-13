mainModule.factory('usersRerpository', function ($http, $q) {
    return {
        get: function () {
            var defferd = $q.defer();
            $http.get('/AngularJS.Practice/Users').success(defferd.resolve).error(defferd.reject);
            
            return defferd.promise;
            
        }

};


});