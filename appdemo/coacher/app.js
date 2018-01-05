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
    // $scope.tab = true;
    $scope.topics = [];
    // {      
    //     "IdDeTai": 14,
    //     "TenDT": "Soi Lô AUTO",
    //     "MoTa": "vai",
    //     "NoiDung": "sdssdsdsd",
    //     "DoKho": 5,
    //     "IdGV": 13,
    //     "TenGV": "Lê Trung Thực",
    //     "Id": 0,
    //     "TrangThai": "1"
    // }
    var data;
    $scope.load = function () {
        $http.get("http://localhost:50132/coacher/gettopic", {})
            .then(
            function success(response) {
                if (response.data.Code == 0) {
                    data = response.data.Data;
                    $scope.tab(2);
                }
            },
            function error(response) {

            });
    }

    $scope.tab = function (tab) {
        $scope.topics = [];
        if (tab == 1) {
            $scope.me = true;
            $scope.topics = data.AllTopics;
        }
        if (tab == 2) {
            $scope.me = false;
            $scope.topics = data.TopicsOfCoacher;
        }
    };

    $scope.preupdate = function (index, idDT) {
        $scope.btnDel = false;
        $scope.title = "Cập nhật đề tài";
        $scope.topicSelected = Object.assign({}, $scope.topics[index]);
    };

    $scope.submit = function () {
        // $scope.topicSelected = Object.assign({}, $scope.topics[index]);
        if ($scope.topicSelected.IdDeTai == null) {
            // create
            $http.post("http://localhost:50132/coacher/addtopic", $scope.topicSelected)
                .then(
                function success(response) {
                    $scope.load();
                },
                function error(response) {
                    alert('fail');
                });
        } else {
            // update
            $http.put("http://localhost:50132/coacher/updatetopic/" + $scope.topicSelected.IdDeTai, $scope.topicSelected)
                .then(
                function success(response) {
                    if (response.data.Code == 0) {
                        $scope.load();
                    }
                },
                function error(response) {
                    alert('fail');
                });
        }

        $("#myModal").modal("hide");
    };
    $scope.delete = function () {
        // $scope.topicSelected = Object.assign({}, $scope.topics[index]);
        $http.get("http://localhost:50132/coacher/gettopic", {})
            .then(
            function success(response) {
                if (response.data.Code == 0) {
                    $scope.load;
                }
            },
            function error(response) {

            });
        $("#myModal").modal("hide");
    };

    $scope.precreate = function () {
        $scope.title = "Tạo đề tài";
        $scope.btnDel = true;
        $scope.topicSelected = {};
    };





});
app.controller("manageproject", function ($scope, $localStorage, $sessionStorage, $http) {
    $http.defaults.headers.common.Authorization = $sessionStorage.session.Token;
    $scope.trainers = [];
    $scope.reports = [];
    var data;
    $scope.load = function () {
        $http.get("http://localhost:50132/coacher/getstudentmanaged", {}
        ).then(
            function success(response) {
                if (response.data.Code == 0)
                    data = response.data.Data;
            },
            function error(response) {
                alert("Load fail !");
            });
    };
    $scope.tab = function (tab) {
        $scope.topics = [];
        if (tab == 1) {
            $scope.show = false;
            $scope.trainers = data.OldTopicRegister;
        }
        if (tab == 2) {
            $scope.show = true;
            $scope.trainers = data.CurentTopicRegister;
        }
    };

    $scope.loadReport = function (index) {
        $scope.reports = [];
        var id = $scope.trainers[index].Id;
        $http.get("http://localhost:50132/coacher/report/" + id, {})
            .then(
            function success(response) {
                if (response.data.Code == 0)
                    $scope.reports = response.data.Data;
            },
            function error(response) {
                alert("Load fail !");
            });
    };
    $scope.save = function (index) {
        var id = $scope.reports[index].ID;
        if (!($scope.reports[index].KetQua == "" || $scope.reports[index].KetQua == null)) {
            $http.post("http://localhost:50132/coacher/report",
                {
                    IdReport: id,
                    Point: $scope.reports[index].KetQua
                })
                .then(
                function success(response) {
                    if (response.data.Code == 0)
                        alert("Thành công ");
                    else
                        alert("Lỗi cmmr ");

                },
                function error(response) {
                    alert("Load fail !");
                });
        }else{
            alert("Chưa nhập gì,hihi??");
        }
    };

});