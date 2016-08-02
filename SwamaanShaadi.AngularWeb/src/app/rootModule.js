(function () {

    'use strict';

    var rootModule = angular.module('swamaanShaadi', ['ngComponentRouter', 'swamaanshaadi.common']);

    rootModule.value('$routerRootComponent', 'rootComponent');

})();
