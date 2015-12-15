(function (app) {

    var todoController = function ($scope, taskService) {

        var onError = function () {
            alert("Error");
        };

        var gotTasks = function(response) {
            $scope.tasks = response.data;
        };

        var init = function () {
            taskService.getTasks().then(gotTasks, onError);
        };

        //[{ Description: "Order lunch", DueDate: "2015/12/07", Status: 0 },
        // { Description: "MOT", DueDate: "2016/01/15", Status: 0 },
        // { Description: "PSM Certification", DueDate: "2016/02/01", Status: 0 },
        // { Description: "Buy brother Anniversary gift", DueDate: "2016/02/15", Status: 0 },
        // { Description: "buy xmas jumpers!", DueDate: "2015/12/21", Status: 0 }];

        init();
    };

    app.controller("todoController", ["$scope", "taskService", todoController]);
    
}(angular.module("todoApp")));