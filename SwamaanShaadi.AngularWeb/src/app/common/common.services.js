(function () {
    "use strict";

    angular
        .module("common.services", ["ngResource"])
        .constant("appSettings",
        {
            serverPath: "http://localhost:56057/"
            //serverPath: "http://webapi.swamaanshaadi.com/"
        });
}());