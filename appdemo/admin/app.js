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
    $scope.faculties = [{ MaKhoa: "aa", TenKhoa: "aaaaa" }, { MaKhoa: "aa", TenKhoa: "aaaaa" }, { MaKhoa: "aa", TenKhoa: "aaaaa" }];
    $http.defaults.headers.common.Authorization = $sessionStorage.session.Token;
    // $scope.tab = true;
    $scope.topics = [{
        IdDeTai: "1",
        TenDT: "sss",
        NoiDung: "sss",
        MoTa: "ssss",
        DoKho: 1,
        TenGV: "ss",
        TrangThai: "ssss"
    }];
    var data;
    $scope.load = function () {
        $http.get("http://localhost:50132/coacher/gettopic", {})
            .then(
            function success(response) {
                if (response.data.Code == 0) {
                    data = response.data.Data;
                }
            },
            function error(response) {

            });
    }

    $scope.tab = function (tab) {
        $scope.topics=[];
        if (tab == 1) {
            $scope.me = true;
            $scope.topics=data.AllTopics;
        }
        if (tab == 2) {
            $scope.me = false;
            $scope.topics=data.TopicsOfCoacher;
        }
    };

    $scope.preupdate = function (index, idDT) {
        $scope.title = "Cập nhật đề tài";
        $scope.topicSelected = Object.assign({}, $scope.topics[index]);
    };

    $scope.submit = function () {
        $scope.topicSelected = Object.assign({}, $scope.topics[index]);
        $("#myModal").modal("hide");
    };
    $scope.delete = function () {

        $scope.topicSelected = Object.assign({}, $scope.topics[index]);
        $("#myModal").modal("hide");
    };

    $scope.precreate = function () {
        $scope.title = "Tạo đề tài";
        $scope.topicSelected = {};
    };





});
app.controller("manageproject", function ($scope, $localStorage, $sessionStorage, $http) {
    $scope.add=false;
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