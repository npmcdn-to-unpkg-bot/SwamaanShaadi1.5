(function () {
    "use strict";

    angular
        .module("common.services")
        .factory("memberMatchHistoryService", MemberMatchHistoryService);

    MemberMatchHistoryService.$inject = ['$resource', 'appSettings', 'currentUser'];   
    function MemberMatchHistoryService($resource, appSettings, currentUser) {
        return $resource(appSettings.serverPath + "/api/MemberMatchHistory/:memberId", null,
            {
                'query': {
                    method: 'GET', isArray: true,
                    headers: { 'Authorization': 'Bearer ' + currentUser.getProfile().token }
                },

                'get': {
                    headers: { 'Authorization': 'Bearer ' + currentUser.getProfile().token }
                }
            }
            );
    }
}());