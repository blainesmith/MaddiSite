angular.module('MadSite').controller('appCtrl', [
    '$rootScope',
    '$scope',
    '$location',
    function ($rootScope, $scope, $location) {
        $scope.model = {};

        $scope.navigateHome = function () {
            $rootScope.busy = true;
            $location.path('/home');
        };
    }]);

