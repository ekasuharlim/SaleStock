angular.module('ourShop', [])
.controller('productList', function ($scope, $http) {
    $http.get('/Productlist/page/1').
        then(function (response) {
            $scope.productList = response.data;
        });

    $scope.ShowDetail = function (productId) {
        window.location.href = '/View/Product/' + productId
    }

})
.controller('productDetail', function ($scope, $http) {
    $scope.ItemsOnCart = 0;
    $scope.ShowProduct = function (id) {
        $http.get('/ProductDetail/' + id).
            then(function (response) {
                $scope.product = response.data;
            });

        $http.get('/Cart').
            then(function (response) {
                $scope.ItemsOnCart = response.data.productList.length;
            });

    }

    $scope.AddToCart = function (id) {
        $http.post('/Cart',id).
        then(function (response) {
            $scope.ItemsOnCart = response.data.itemCount;
        });
    }

    $scope.CheckOut = function (productId) {
        window.location.href = '/View/Checkout'
    }
})
.controller('CheckOut', function ($scope, $http) {
    $scope.ItemsOnCart = 0;
    $scope.ShowCart = function () {
        $http.get('/Cart').
            then(function (response) {
                $scope.productList = response.data.productList;
            });
    }

    $scope.AddMore = function () {
        window.location.href = '/'
    }

})

;

