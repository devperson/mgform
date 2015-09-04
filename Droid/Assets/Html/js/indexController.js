angular.module('clientApp').controller('indexController', ['$scope', function ($scope)
{
    
    $scope.GetUser = function () {
        return JSON.stringify($scope.user);
    };

    //$scope.SubmitForm = function (user)
    //{
    //    alert(JSON.stringify(user));
    //};
    

} ]);

