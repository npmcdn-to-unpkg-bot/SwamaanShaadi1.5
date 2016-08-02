(function () {

    'use strict';

    var rootModule = angular.module('swamaanShaadi', ['ngComponentRouter', 'common.services']);

    rootModule.value('$routerRootComponent', 'rootComponent');

})();
