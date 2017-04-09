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
    $scope.ShowProduct = function (id) {
        $http.get('/ProductDetail/' + id).
            then(function (response) {
                $scope.product = response.data;
            });
    }
});

