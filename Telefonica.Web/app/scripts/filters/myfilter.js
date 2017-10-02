/**
@description 
*/
(function () {
    'use strict';

    angular.module('app.telefonicaApp')
        .filter('dateFilter', ["$filter", function ($filter) {

            return function (input, start, end) {
                var inputDate = new Date(input),
                    startDate = new Date(start),
                    endDate = new Date(end),
                    result = [];

                for (var i = 0, len = input.length; i < len; i++) {
                    inputDate = new Date(input[i].DepartureDateTime);
                    if (startDate < inputDate && inputDate < endDate) {
                        result.push(input[i]);
                    }
                }
            }
        }]);

})();

