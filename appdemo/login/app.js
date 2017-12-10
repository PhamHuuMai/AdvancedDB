var loginapp = angular.module("login", ["ngRoute", "ngStorage"]);
loginapp.config(function ($routeProvider) {
    $routeProvider
        .when("/", {
            templateUrl: "index.htm",
            resolve: {
                message: function () {
                    // window.location.href = "/student";
                }
            }
        });
});
loginapp.controller("login", function ($scope, $localStorage, $sessionStorage, $http) {
    $scope.alertTitle = 'Loading................................ ';
    // login 
    $scope.login = function () {
        $http.post("http://localhost:50132/login", {
            userName: $scope.username,
            password: $scope.password
        }
        ).then(
            function success(response) {
                var code = response.data.Code;
                var data = response.data.Data;
                if (code == 0) {
                    if (data.Role == 1) {
                        $localStorage.session=data;
                        $sessionStorage.session=data;
                        window.location.href = "/student";
                    } else {
                        if (data.Role == 2) {
                            $localStorage.session=data;
                            $sessionStorage.session=data;
                            window.location.href = "/coacher";
                        } else {
                            $localStorage.session=data;
                            $sessionStorage.session=data;
                            window.location.href = "/admin";
                        }
                    }
                } else {
                    $scope.alert = 'warning';
                    $scope.alertTitle = 'Lỗi đăng nhập ! ';
                    $scope.alertMessage = 'Tên đăng nhập hoặc mật khẩu sai ?';
                }
            },
            function error(response) {
                $scope.alert = 'danger';
                $scope.alertTitle = 'Server bảo trì !';
                $scope.alertMessage = '(^_^)';
            });



    }
});