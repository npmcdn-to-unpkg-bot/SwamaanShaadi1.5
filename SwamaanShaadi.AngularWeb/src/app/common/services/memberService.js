(function() {
'use strict';

    angular
        .module('common.services')
        .factory('memberService', MemberService);

    MemberService.$inject = ['$resource', 'appSettings', 'currentUser'];
    function MemberService($resource, appSettings, currentUser) {
        return $resource(appSettings.serverPath + "/api/members/:memberId", null,
            {
                'query': {
                    method: 'GET', isArray:true,
                    headers: { 'Authorization': 'Bearer ' + currentUser.getProfile().token }
                },

                'get': {
                    headers: { 'Authorization': 'Bearer ' + currentUser.getProfile().token }
                },

                'save': {
                    headers: { 'Authorization': 'Bearer ' + currentUser.getProfile().token }
                },

                'update': {
                    method: 'PUT',
                    headers: { 'Authorization': 'Bearer ' + currentUser.getProfile().token }
                }
            });
    }
})();