(function () {
    'use strict';

    var module = angular.module("swamaanShaadi");

    module.component("employmentInfo", {
        templateUrl: "app/memberProfile/employmentInfo/employmentInfo.component.html",
        require: { parent: '^memberProfile' },
        bindings: { $router: '<' },
        controller: EmploymentInfoController,
        controllerAs: 'employment'
    });

    EmploymentInfoController.$inject = ['lookupDataService'];
    function EmploymentInfoController(lookupDataService) {
        var vm = this;
        vm.$onInit = activate;
        vm.$routerOnActivate = function (next, previous) {

        };

        function activate() {
            vm.model = this.parent.model;
        }
    }

})();