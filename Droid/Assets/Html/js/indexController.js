angular.module('clientApp').controller('indexController', ['$scope', function ($scope) {

    $scope.user = {};
    $scope.user.ExpenseItems = [];
    $scope.user.StolenItems = [];

    $scope.NewStolenItems = function () {
        $scope.user.StolenItems.push({ Name: "", Ammount: "" });
    };
    $scope.NewStolenItems();

    $scope.NewExpenseItem = function () {
        $scope.user.ExpenseItems.push({ Name: "", Ammount: "" });
    };
    $scope.NewExpenseItem();

    $scope.GetUser = function () {
        return JSON.stringify($scope.user);
    };    

} ]);

