'use strict';

/**
 * @ngdoc overview
 * @name telefonicaApp
 * @description
 * # telefonicaApp
 *
 * Main module of the application.
 */
angular
  .module('telefonicaApp', [
    'ngAnimate',
    'ngCookies',
    'ngResource',
    'ngRoute',
    'ngSanitize',
    'ngTouch',
    'ngMaterial'
  ])
  .config(function ($routeProvider) {
    $routeProvider
      .when('/', {
        templateUrl: 'app/views/main.html',
        controller: 'MainCtrl',
        controllerAs: 'vm'
      })
      .when('/usuarios', {
        templateUrl: 'app/views/usuarios.html',
        controller: 'UsuariosCtrl',
        controllerAs: 'vm'
      })
      .when('/telefonos', {
        templateUrl: 'app/views/telefonos.html',
        controller: 'TelefonosCtrl',
        controllerAs: 'vm'
      })
      .when('/llamadas', {
        templateUrl: 'app/views/llamadas.html',
        controller: 'LlamadasCtrl',
        controllerAs: 'vm'
      })
      .otherwise({
        redirectTo: '/'
      });
  });
