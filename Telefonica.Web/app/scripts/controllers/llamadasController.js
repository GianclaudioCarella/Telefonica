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
      vm.getLlamadasCosto = getLlamadasCosto;
      vm.selectedItem = selectedItem;

      vm.startDate;
      vm.endDate;
      vm.total = 0;

      vm.llamada = {};
      vm.costollamada = 0.0;

      vm.tab = true;
      

      function getLlamadas(inicio, fin) {

          var i = inicio.toISOString().slice(0, 10).replace(/-/g, "-");
          var f = fin.toISOString().slice(0, 10).replace(/-/g, "-");

          return $http({
              method: 'GET',
              url: serviceRoot + 'api/Llamada/' + i + '/' + f + "",
          }).then(sucess, fail);

          function sucess(response) {
              vm.llamadas = response.data;
              getLlamadasCosto(inicio, fin);
              return vm.llamadas;
          }
          function fail(response) {
              return response;
          }
      }

      function getLlamadasCosto(inicio, fin) {
          var i = inicio.toISOString().slice(0, 10).replace(/-/g, "-");
          var f = fin.toISOString().slice(0, 10).replace(/-/g, "-");

          return $http({
              method: 'GET',
              url: serviceRoot + 'api/Llamada/CalculaCosto/' + i + '/' + f + "",
          }).then(sucess, fail);

          function sucess(response) {
              vm.total = response.data
              return vm.total;
          }
          function fail(response) {
              return response;
          }
      }

      function selectedItem(item) {

          vm.llamada = item;

          return $http({
              method: 'GET',
              url: serviceRoot + 'api/Llamada/CalculaCosto/' + item.LlamadaId + "",
          }).then(sucess, fail);

          function sucess(response) {
              vm.costollamada = response.data
              vm.tab = false;
              return vm.total;
          }
          function fail(response) {
              return response;
          }

      }
  }


})();

