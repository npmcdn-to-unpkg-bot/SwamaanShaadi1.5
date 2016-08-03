(function () {
    'use strict';

    var module = angular.module("swamaanShaadi");

    module.component("rootComponent", {
        templateUrl: "app/root/root.component.html",
        $routeConfig: [
            { path: "/home", component: "home", name: "Home" },
            { path: "/login", component: "login", name: "Login" },
            { path: "/register", component: "register", name: "Register" },
            { path: "/myProfile/...", component: "memberProfile", name: "MemberProfile" },
            { path: "/matchHistory", component: "matchHistory", name: "MatchHistory" },
            { path: "/**", redirectTo: ["Home"] }
        ]
    });
})();