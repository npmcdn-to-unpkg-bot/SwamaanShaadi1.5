(function () {
    'use strict';

    var module = angular.module("swamaanShaadi");

    module.component("partnerSearchCriteria", {
        templateUrl: "app/memberProfile/partnerSearchCriteria/partnerSearchCriteria.component.html",
        require: { parent: '^memberProfile' },
        bindings: { $router: '<' },
        controller: PartnerSearchCriteriaController,
        controllerAs: 'search'
    });

    PartnerSearchCriteriaController.$inject = ['lookupDataService'];
    function PartnerSearchCriteriaController(lookupDataService) {
        var vm = this;
        vm.$onInit = activate;
        vm.$routerOnActivate = function (next, previous) {

        };

        function activate() {
            vm.model = this.parent.model;
        }
    }

})();