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
    $scope.faculties = [];
    // $http.defaults.headers.common.Authorization = $sessionStorage.session.Token;
    $scope.khoa;
    $scope.topics = [];
    $scope.load = function () {
        $http.get(host+"admin/khoas", {})
            .then(
            function success(response) {
                if (response.data.Code == 0) {
                    $scope.faculties = response.data.Data;
                }
            },
            function error(response) {

            });
    };

    $scope.seach = function () {
        $http.get(host+"admin/khoas/" + $scope.khoa + "/topic", {})
            .then(
            function success(response) {
                if (response.data.Code == 0) {
                    $scope.topics = response.data.Data;
                }
            },
            function error(response) {

            });
    };
    $scope.status = function (status) {
        if (status == 1)
            return "approve";
        if (status == 0)
            return "pendding";
        if (status == -1)
            return "deny";
    };
    $scope.changeStatus = function (id, status) {
        $http.put(host+"admin/topic/" + id + "/status/" + status, {})
            .then(
            function success(response) {
                if (response.data.Code == 0) {
                    $scope.seach();
                }
            },
            function error(response) {

            });
    }

    $scope.appBtn = function (status) {
        if (status == 1)
            return "btn-danger";
        return "";
    };
    $scope.penBtn = function (status) {
        if (status == 0)
            return "btn-danger";
        return "";
    };
    $scope.denBtn = function (status) {
        if (status == -1)
            return "btn-danger";
        return "";
    };

});
app.controller("protect", function ($scope, $localStorage, $sessionStorage, $http) {
    $scope.khoa;
    $scope.hd = [];
    $scope.hdInfor = {};
    $scope.hdDetail = [];
    $scope.load = function () {
        $http.get(host+"admin/getallhd", {})
            .then(
            function success(response) {
                if (response.data.Code == 0) {
                    $scope.hd = response.data.Data;
                }
            },
            function error(response) {

            });
        $http.get(host+"admin/khoas", {})
            .then(
            function success(response) {
                if (response.data.Code == 0) {
                    $scope.faculties = response.data.Data;
                }
            },
            function error(response) {

            });
    };
    $scope.detail = function (index) {
        var id = $scope.hd[index].Id;
        $scope.deleteBtn = true;
        $scope.khoa = $scope.hd[index].IdKhoa;
        $scope.ahihi = true;
        $http.get(host+"admin/gethddetail/" + id, {})
            .then(
            function success(response) {
                if (response.data.Code == 0) {
                    $scope.hdInfor = response.data.Data.HDInfor;
                    $scope.hdDetail = response.data.Data.HDDetai;
                }
            },
            function error(response) {

            });
    };
    $scope.delete = function (index) {
        $scope.hdDetail.splice(index, 1);
    };
    $scope.list = function () {
        $scope.add = !$scope.add;
        $scope.coachers = [];
        $http.get(host+"admin/khoa/" + $scope.khoa + "/giaovien", {})
            .then(
            function success(response) {
                if (response.data.Code == 0) {
                    $scope.coachers = response.data.Data;
                }
            },
            function error(response) {

            });
    };
    $scope.push = function (index) {
        var temp = $scope.coachers[index];
        var check = true;
        $scope.hdDetail.forEach(function (item) {
            if (temp.Id == item.IdGV)
                check = false;
        })
        if (check) {
            $scope.hdDetail.push({
                IdHd: 1,
                IdGV: temp.Id,
                TenGV: temp.Ten,
                ViTri: temp.Id
            });
        }
    };
    $scope.precreate = function () {
        $scope.hdInfor = {};
        $scope.hdDetail = [];
        $scope.ahihi = false;
        $scope.deleteBtn = false;
    };
    $scope.clk = function () {
        $scope.khoa = $scope.hdInfor.IdKhoa;
        $scope.list();
    }
    $scope.submit = function () {
        if ($scope.hdInfor.Id == null) {
            // add
            $http.post(host+"admin/hd",
                {
                    hdInfor: $scope.hdInfor,
                    hdDetail: $scope.hdDetail
                })
                .then(
                function success(response) {
                    if (response.data.Code == 0) {
                        $scope.load();
                        $("#myModal").modal("hide");
                    } else {
                        alert("Fail rooif");
                    }
                },
                function error(response) {
                    alert("Fail rooif");
                });
        } else {
            // update
            $http.put(host+"admin/hd",
                {
                    hdInfor: $scope.hdInfor,
                    hdDetail: $scope.hdDetail
                })
                .then(
                function success(response) {
                    if (response.data.Code == 0) {
                        $scope.load();
                        $("#myModal").modal("hide");
                    } else {
                        alert("Fail rooif");
                    }
                },
                function error(response) {
                    alert("Fail rooif");
                });
        }
    };
    $scope.delete1 = function () {
        var id = $scope.hdInfor.Id;
        $http.delete(host+"admin/hd/" + id, {})
            .then(
            function success(response) {
                if (response.data.Code == 0) {
                    $scope.load();
                    $("#myModal").modal("hide");
                }
            },
            function error(response) {
                alert("Fail rooif");
            });
    }

});