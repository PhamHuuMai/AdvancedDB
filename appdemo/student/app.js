var app = angular.module("app", ["ngRoute", "ngStorage"]);

app.config(function ($routeProvider) {
    $routeProvider
        .when("/", {
            template: ""
        })
        .when("/registertopic", {
            templateUrl: "view/register_topic.html"
        })
        .when("/reporttopic", {
            templateUrl: "view/report_topic.html"
        });
});
app.controller("myCtrl", function ($scope, $localStorage, $sessionStorage, $http) {
    $http.defaults.headers.common.Authorization = $localStorage.session.Token;
    $scope.selector = [];
    $scope.selected = [];
    $scope.handleTableUp = function (x, id) {
        if ($scope.selected.length == 0) {
            $scope.selected.push($scope.selector[x]);
            //$scope.selector.splice(x, 1);
            $scope.IdDt = id;
        }
    };
    $scope.handleTableDown = function (x, id) {
        // $scope.selector.push($scope.selected[x]);
        $scope.IdDt = null;
        $scope.selected.splice(x, 1);
    };
    $scope.submit = function () {
        if ($scope.IdDt != null) {
            $http.post(host + "student/register/" + $scope.IdDt, {})
                .then(
                function success(response) {
                    if (response.data.Code != 0) {
                        alert("Đăng kí ko thành công , OK !");
                    }
                },
                function error(response) {
                    alert("Đăng kí ko thành công , OK !");
                });
        } else {
            alert("Chưa chọn đề tài hoặc đề tài ko thay đổi , OK!");
        }
    };

    $scope.load = function () {
        // alert($sessionStorage.session.Token);
        // alert($localStorage.session.Token);


        $http.get(host + "student/register", {})
            .then(
            function success(response) {
                var code = response.data.Code;
                if (code == 0) {
                    $scope.selected = [];
                    $scope.StudentInfor = response.data.Data.StudentInfor;
                    $scope.selector = response.data.Data.ListTopic;
                    if (response.data.Data.TopicRegisted != null) {
                        $scope.IdDt = null;
                        $scope.selected.push(response.data.Data.TopicRegisted);
                    } else {
                        $scope.selected = [];
                    }
                }
            },
            function error(response) {

            });
    }

});
app.controller("report", function ($scope, $localStorage, $sessionStorage, $http) {
    $http.defaults.headers.common.Authorization = $localStorage.session.Token;
    $scope.flag = 0;
    $scope.load = function () {
        $http.get(host + "student/report", {})
            .then(
            function success(response) {
                if (response.data.Code == 0) {
                    $scope.topicRegisted = response.data.Data.TopicRegisted;
                    $scope.reports = response.data.Data.Reports;
                    $scope.idDk = $scope.topicRegisted.ID;
                }
            },
            function error(response) {

            });
    };
    $scope.add = function () {
        $scope.flag = 1;
        $scope.title = "Tạo báo cáo";
    };
    $scope.selectReport = function (index) {
        $scope.title = "Sửa báo cáo";
        $scope.flag = 2;
        $("#myModal").modal("show");
        $scope.reportSelected = $scope.reports[index];
        $scope.content = $scope.reportSelected.NoiDung;
        $scope.file = $scope.reportSelected.File;
    };
    $scope.save = function () {

        $http.put(host + "student/report/" + $scope.reportSelected.ID,
            {
                content: $scope.content,
                file: $scope.file
            })
            .then(
            function success(response) {
                if (response.data.Code == 0) {
                    $scope.load();
                    $("#myModal").modal("hide");
                } else {
                    alert("Lưu báo cáo thất bại (^-^) ")
                }
            },
            function error(response) {

            });
    };
    $scope.remove = function () {
        $http.delete(host + "student/report/" + $scope.reportSelected.ID, {})
            .then(
            function success(response) {
                if (response.data.Code == 0) {
                    $scope.load();
                    $("#myModal").modal("hide");
                } else {
                    alert("Xóa báo cáo thất bại (^-^) ")
                }
            },
            function error(response) {

            });
    };
    $scope.submitCreater = function () {
        $scope.flag = 1;
        $http.post(host + "student/report",
            {
                idDk: $scope.topicRegisted.Id,
                content: $scope.content,
                file: $scope.file
            })
            .then(
            function success(response) {
                if (response.data.Code == 0) {
                    $scope.load();
                    $("#myModal").modal("hide");
                } else {
                    alert("Tạo báo cáo thất bại (^-^) ")
                }
            },
            function error(response) {

            });
    }

});

