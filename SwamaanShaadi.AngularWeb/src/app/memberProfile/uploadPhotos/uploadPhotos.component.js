(function () {
    'use strict';

    var module = angular.module("swamaanShaadi");

    module.component("uploadPhotos", {
        templateUrl: "app/memberProfile/uploadPhotos/uploadPhotos.component.html",
        require: { parent: '^memberProfile' },
        bindings: { $router: '<' },
        controller: UploadPhotoController,
        controllerAs: 'info'
    });

    function UploadPhotoController() {
        var vm = this;
        vm.$onInit = activate;
        vm.$routerOnActivate = function (next, previous) {

        };

        function activate() {
            vm.model = this.parent.model;
        }
    }

})();