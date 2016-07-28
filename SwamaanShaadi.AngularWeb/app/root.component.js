(function () {
    'use strict';

    var module = angular.module("swamaanShaadi");

    module.component("rootComponent", {
        templateUrl: "/app/root.component.html",
        $routeConfig: [
            { path: "/myProfile", component: "memberProfile", name: "MemberProfile" },
            { path: "/matchHistory", component: "matchHistory", name: "MatchHistory" },
            { path: "/**", redirectTo: ["MemberProfile"] }
        ]
    });
})();