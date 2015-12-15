(function(app) {

    var baseUrl = '/api/Task';

    var taskService = function ($http) {

        var todoFactory = {};

        todoFactory.getTasks = function() {
            return $http.get(baseUrl);
        };

        return todoFactory;


    };


    app.factory("taskService", ["$http", taskService]);

}(angular.module("todoApp")));