angular.module('clientApp').controller('indexController', ['$scope', function ($scope)
{

   
    $scope.SubmitForm = function (user)
    {
        alert(JSON.stringify(user));
    };
    
} ]);
