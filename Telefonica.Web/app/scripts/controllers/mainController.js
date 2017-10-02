/**
 * @ngdoc function
 * @name telefonicaApp.controller:MainCtrl
 * @description
 * # MainCtrl
 * Controller of the telefonicaApp
 */

(function () {
  'use strict';

  var controllerId = 'MainCtrl';

  angular
    .module('telefonicaApp')
    .controller(controllerId, MainCtrl);

  MainCtrl.$inject = ['$http', '$q', '$scope'];

  function MainCtrl($http, $q, $scope) {

    var vm = this;
    vm.title = 'Acerca';

    // function loadByHttpUrl(url) {
    //   return $http({
    //     method: 'GET',
    //     url: url
    //   }).then(extractSvg, announceAndReject);

    //   function announceAndReject(err) {
    //     var msg = angular.isString(err) ? err : (err.message || err.data || err.statusText);
    //     log.error(msg);
    //     return err;
    //     //reject(err);
    //   }
    //   function extractSvg(response) {
    //     return angular.element('<div>').append(response.data)[0].querySelectorAll('svg defs g');
    //   }
    // }
  }
})();