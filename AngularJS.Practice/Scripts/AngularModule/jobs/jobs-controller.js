mainModule.controller('jobs-controller', function ($scope, jobsRerpository) {
    jobsRerpository.get().then(function (jobs) { $scope.jobs = jobs; });
    

});