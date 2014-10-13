mainModule.factory('jobsRerpository', function ($http, $q) {
    return {
        get: function () {
            var defferd = $q.defer();
            $http.get('/AngularJS.Practice/Jobs').success(defferd.resolve).error(defferd.reject);
            
            return defferd.promise;
            
        }

};


});