/**
 * @ngdoc function
 * @name telefonicaApp.controller:LlamadasCtrl
 * @description
 * # Llamadastrl
 * Controller of the telefonicaApp
 */
(function () {
  'use strict';

  var controllerId = 'LlamadasCtrl';

  angular
      .module('telefonicaApp')
    .controller(controllerId, LlamadasCtrl);

  LlamadasCtrl.$inject = ['$http', '$q', '$scope'];

  function LlamadasCtrl($http, $q, $scope) {

      var vm = this;
      vm.title = 'Llamadas';
      vm.llamadas = [];
      var serviceRoot = window.location.protocol + '//' + window.location.host + window.location.pathname;

      vm.usuarios = [];
      vm.getLlamadas = getLlamadas;

      vm.startDate;
      vm.endDate;

      function getLlamadas(inicio, fin) {

          var i = inicio.toISOString().slice(0, 10).replace(/-/g, "-");
          var f = fin.toISOString().slice(0, 10).replace(/-/g, "-");

          return $http({
              method: 'GET',
              url: serviceRoot + 'api/Llamada/' + i + '/' + f + "",
          }).then(sucess, fail);

          function sucess(response) {
              vm.llamadas = response.data;
              return vm.llamadas;
          }
          function fail(response) {
              return response;
          }
      }
  }


})();

