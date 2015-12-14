(function (app) {

    var baseUrl = "/api/flights";

    var flightService = function ($http) {

        //var testData = [
        //    { id: 1, airline: "United", flightNumber: "UA201", startTime: "13:00", endTime: "15:00", totalDuration: 2, price: 500, date: "12/12/2015", cities: ["ORD", "LHR"], approved: false },
        //    { id: 2, airline: "AI", flightNumber: "AI211", startTime: "14:00", endTime: "15:00", totalDuration: 1, price: 200, date: "12/12/2015", cities: ["ORD", "LHR"], approved: false },
        //    { id: 3, airline: "AA", flightNumber: "AA4511", startTime: "11:00", endTime: "15:00", totalDuration: 4, price: 1200, date: "12/12/2015", cities: ["ORD", "LHR"], approved: false }
        //];


        var flightFactory = {};
        flightFactory.getFlights = function () {
            return $http.get(baseUrl);
        };

        flightFactory.selectFlight = function () {
            //$http.put("/flights/select/3", id);

            return true;
        };

        return flightFactory;
    };

    app.factory("flightService", ["$http", flightService]);

}(angular.module("airlineApp")));