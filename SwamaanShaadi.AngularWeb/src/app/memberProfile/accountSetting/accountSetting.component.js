(function () {
    'use strict';

    var module = angular.module("swamaanShaadi");

    module.component("accountSetting", {
        templateUrl: "app/memberProfile/accountSetting/accountSetting.component.html",
        require: { parent: '^memberProfile' },
        bindings: { $router: '<' },
        controller: AccountSettingsController,
        controllerAs: 'setting'
    });

    function AccountSettingsController()
    {
        var vm = this;
        vm.$onInit = activate;
        vm.$routerOnActivate = function (next, previous) {

        };

        function activate() {
            vm.model = this.parent.model;
        }
    }

})();