var app = angular.module("teacher", ["ngRoute", "ngStorage"]);
app.config(function ($routeProvider) {
    $routeProvider
        .when("/topicmanage", {
            templateUrl: "view/topicmanage.html",
            resolve: {
                message: function () {
                    // window.location.href = "/student";
                }
            }
        })
        .when("/projectmanage", {
            templateUrl: "view/projectmanager.html",
            resolve: {
                message: function () {
                    // window.location.href = "/student";
                }
            }
        });
});
app.controller("managetopic", function ($scope, $localStorage, $sessionStorage, $http) {
    $http.defaults.headers.common.Authorization = $sessionStorage.session.Token;
    $scope.tab = true;
    $scope.load = function (tab) {
        if (tab == 1) {
            $http.post("http://localhost:50132/login", {}
            ).then(
                function success(response) {
                },
                function error(response) {
                });
        }
        if (tab == 2) {
            $http.post("http://localhost:50132/login", {}
            ).then(
                function success(response) {
                },
                function error(response) {
                });
        }
    };

    // login 
    $scope.login = function () {
        $http.post("http://localhost:50132/login", {}
        ).then(
            function success(response) {
            },
            function error(response) {
            });
    }
});
app.controller("manageproject", function ($scope, $localStorage, $sessionStorage, $http) {
    $scope.tab = true;
    $scope.tab = function (tab) {
        alert(tab);
        if (tab == 1)
            return true;
        if (tab == 2)
            return false;
    }
    // login 
    $scope.login = function () {
        $http.post("http://localhost:50132/login", {}
        ).then(
            function success(response) {
            },
            function error(response) {
            });
    }
});