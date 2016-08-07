(function () {
    'use strict';

    var module = angular.module("swamaanShaadi");

    module.component("memberProfile", {
        templateUrl: "app/memberProfile/memberProfile.component.html",
        $routeConfig: [
            { path: "/personalInfo", component: "personalInfo", name: "PersonalInfo" },
            { path: "/uploadPhotos", component: "uploadPhotos", name: "UploadPhotos" },
            { path: "/employmentInfo", component: "employmentInfo", name: "EmploymentInfo" },
            { path: "/partnerSearchCriteria", component: "partnerSearchCriteria", name: "PartnerSearchCriteria" },
            { path: "/accountSetting", component: "accountSetting", name: "AccountSetting" },
            { path: "/**", redirectTo: ["PersonalInfo"] }
        ],
        bindings: { $router: '<' },
        controller: MemberProfileController,
        controllerAs: 'profile'
    });

    MemberProfileController.$inject = ['memberService'];
    function MemberProfileController(memberService)
    {
        var vm = this;

        vm.model = { 'Name': '' };

        vm.$onInit = activate;
        vm.$routerOnActivate = function (next, previous) {
            vm.model.Name = "Navendu Kumar";
        };

        function activate() {
            var a = 1;
        }
    }

})();
