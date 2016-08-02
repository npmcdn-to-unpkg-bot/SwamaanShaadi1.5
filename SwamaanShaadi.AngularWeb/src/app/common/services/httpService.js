(function () {
    'use strict';

    angular.module('common.services')
    .factory('httpService', HttpService);

    HttpService.$inject = ['$http', 'appSettings'];

    function HttpService($http, appSettings)
    {
        // GET: http://webapi.swamaanshaadi.com/api/members/9802293243
        var query = function(resource, parameters){
            parameters = parameters || {};
            var uri = appSettings.baseUrl + resource;
            return $http({method: 'GET', url: uri, params: parameters, cache: false});
        };

        var createObject = function(resource, object){
            var uri = appSettings.baseUrl + resource;
            return $http({method: 'POST', url: uri, data: angular.toJson(object), cache: false});
        };

        var updateObject = function(resource, id, object){
            var uri = appSettings.baseUrl + resource + '/' + id;
            return $http({method: 'PUT', url: uri, data: angular.toJson(object), cache: false});
        };

        var deleteObject = function(resource, id, object){
            var uri = appSettings.baseUrl + resource + '/' + id;
            return $http({method: 'DELETE', url: uri, data: angular.toJson(object), cache: false});
        };

        return {
            query: query,
            createObject : createObject,
            updateObject : updateObject,
            deleteObject : deleteObject
        };
    }

})();