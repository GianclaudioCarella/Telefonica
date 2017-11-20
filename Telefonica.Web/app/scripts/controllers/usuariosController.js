/**
 * @ngdoc function
 * @name telefonicaApp.controller:UsuariosCtrl
 * @description
 * # UsuariosCtrl
 * Controller of the telefonicaApp
 */
(function () {
  'use strict';

  var controllerId = 'UsuariosCtrl';

  angular
    .module('telefonicaApp')
    .controller(controllerId, UsuariosCtrl);

  UsuariosCtrl.$inject = ['$http', '$q', '$scope'];

  function UsuariosCtrl($http, $q, $scope) {

      var vm = this;
      vm.title = 'Usuarios';
      vm.usuarios = [];
      var serviceRoot = window.location.protocol + '//' + window.location.host + window.location.pathname;
      vm.printDiv = printDiv;

      vm.usuarios = getUsuarios();

      function getUsuarios() {
          return $http({
              method: 'GET',
              url: serviceRoot + 'api/Usuario'
          }).then(sucess, fail);

          function sucess(response) {
              vm.usuarios = response.data;
              return vm.usuarios;
          }
          function fail(response) {
              return response;
          }
      }


      function printDiv(divName) {
          var printContents = document.getElementById(divName).innerHTML;
          var popupWin = window.open('', '_blank', 'width=800,height=800');
          popupWin.document.open();
          popupWin.document.write('<html><head><link rel="stylesheet" type="text/css" href="../../styles/style.css" /></head><body onload="window.print()">' + printContents + '</body></html>');
          popupWin.document.close();
      }

      


  }
})();
