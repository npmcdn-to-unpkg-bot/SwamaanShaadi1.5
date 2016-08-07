(function () {
    "use strict";

    angular
        .module("common.services")
        .factory("lookupDataService", LookupDataService);

    LookupDataService.$inject = ["$resource", "appSettings", "currentUser"];    
    function LookupDataService($resource, appSettings, currentUser) {
        return $resource(appSettings.serverPath + "/api/lookupData", null,
            {
                'get': {
                    headers: { 'Authorization': 'Bearer ' + currentUser.getProfile().token }
                }
            });
    }

}());