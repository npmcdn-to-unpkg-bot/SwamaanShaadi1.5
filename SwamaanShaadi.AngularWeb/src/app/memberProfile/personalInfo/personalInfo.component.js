(function () {
    'use strict';

    var module = angular.module("swamaanShaadi");

    module.component("personalInfo", {
        templateUrl: "app/memberProfile/personalInfo/personalInfo.component.html",
        require: { parent: '^memberProfile' },
        bindings: { $router: '<' },
        controller: PersonalInfoController,
        controllerAs: 'info'
    });

    PersonalInfoController.$inject = ['lookupDataService'];
    function PersonalInfoController(lookupDataService) {
        var vm = this;
        vm.$onInit = activate;
        vm.$routerOnActivate = function (next, previous) {
            
        };

        function activate()
        {
            vm.model = this.parent.model;
        }
    }

})();