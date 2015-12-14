(function (app) {

    var flightController = function ($scope, flightService, $timeout) {

        var onError = function() {
            alert("Error");
        };

        var onGotFlights = function (response) {
            $scope.flights = response.data;
        };

        var init = function() {
            $scope.flights = flightService.getFlights().then(onGotFlights, onError);
        }

        $scope.selectFlight = function(flight) {
            for (var i = 0; i < $scope.flights.length; i++) {
                $scope.flights[i].approved = false;
            }
            flight.approved = !flight.approved;
           if (flightService.selectFlight(flight.id)) {
               $scope.status = "selected!";
               $timeout(function() {
                   $scope.status = null;
               }, 3000);

           };
        }

        init();
    }


    app.controller("flightsController", [
        "$scope", "flightService", "$timeout", flightController]);

}(angular.module("airlineApp")));