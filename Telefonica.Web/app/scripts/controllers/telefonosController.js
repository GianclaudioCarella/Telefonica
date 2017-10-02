/**
 * @ngdoc function
 * @name telefonicaApp.controller:TelefonosCtrl
 * @description
 * # AboutCtrl
 * Controller of the telefonicaApp
 */
(function () {
    'use strict';

    var controllerId = 'TelefonosCtrl';

    angular
        .module('telefonicaApp')
        .controller(controllerId, TelefonosCtrl);

    TelefonosCtrl.$inject = ['$http', '$q', '$scope'];

    function TelefonosCtrl($http, $q, $scope) {

        var vm = this;
        vm.title = 'Telefonos';
        vm.telefonos = [];
        var serviceRoot = window.location.protocol + '//' + window.location.host + window.location.pathname;

        getTelefonos();

        function getTelefonos() {
            return $http({
                method: 'GET',
                url: serviceRoot + 'api/Telefono'
            }).then(sucess, fail);

            function sucess(response) {
                vm.telefonos = response.data;
                return vm.telefonos;
            }
            function fail(response) {
                return response;
            }
        }
    }
})();

