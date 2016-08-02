(function() {
'use strict';

var app = angular.module('swamaanShaadiMock', ['ngMockE2E']);

app.run(runMock);

function runMock($httpBackend)
{
    var members = [
        {
            "memberId": 1,
            "userName":"9802293243",
            "firstName":"Radha 1",
            "middleName":"",
            "lastName":"Kumari",
            "fatherName":"Kishan Babu",
            "dateOfBirth":"1983-01-19T00:00:00",
            "mobileNo":9802293243,
            "emailId":null,
            "profileForId":2,
            "genderId":2,
            "religionId":1,
            "casteId":null,
            "address":"Village: Belhi\nThana: Laukahi",
            "districtId":1,
            "stateId":1,
            "countryId":1,
            "maritalStatusId":1,
            "photographs":
                ["MemberPhotographs\\9802293243\\10685337_1540648549505334_1312793180158511818_n.jpg",
                "MemberPhotographs\\9802293243\\10947266_1598115890425266_343687920104590504_n.jpg"],
            "employmentTypeId":2,
            "companyName":"Self",
            "workLocationAddress":"Not available",
            "educationId":3,
            "partnerMinAge":35,
            "partnerMaxAge":45,
            "partnerCasteId":null,
            "partnerReligionId":null,
            "partnerEducationId":null,
            "partnerEmploymentTypeId":1,
            "partnerMaritalStatusId":null,
            "registrationDate":"2016-04-24T08:02:04.13",
            "mobileAlertSubscription":1,
            "emailAlertSubscription":2,
            "accountStatusId":1
        },
        {
            "memberId": 2,
            "userName":"9802293244",
            "firstName":"Radha 2",
            "middleName":"",
            "lastName":"Kumari",
            "fatherName":"Kishan Babu",
            "dateOfBirth":"1983-01-19T00:00:00",
            "mobileNo":9802293243,
            "emailId":null,
            "profileForId":2,
            "genderId":2,
            "religionId":1,
            "casteId":null,
            "address":"Village: Belhi\nThana: Laukahi",
            "districtId":1,
            "stateId":1,
            "countryId":1,
            "maritalStatusId":1,
            "photographs":
                ["MemberPhotographs\\9802293243\\10685337_1540648549505334_1312793180158511818_n.jpg",
                "MemberPhotographs\\9802293243\\10947266_1598115890425266_343687920104590504_n.jpg"],
            "employmentTypeId":2,
            "companyName":"Self",
            "workLocationAddress":"Not available",
            "educationId":3,
            "partnerMinAge":35,
            "partnerMaxAge":45,
            "partnerCasteId":null,
            "partnerReligionId":null,
            "partnerEducationId":null,
            "partnerEmploymentTypeId":1,
            "partnerMaritalStatusId":null,
            "registrationDate":"2016-04-24T08:02:04.13",
            "mobileAlertSubscription":1,
            "emailAlertSubscription":2,
            "accountStatusId":1
        }
    ];

    var allDropDownData = 
    {
        "districts":
            [
                {"id":1,"name":"Madhubani","stateID":1},
                {"id":null,"name":"","stateID":0}],
        "states":
            [
                {"id":1,"name":"Bihar","countryID":1}
            ],
        "countries":
            [
                {"id":1,"name":"India"}
            ],
        "religions":
            [
                {"id":1,"name":"Hindu"},
                {"id":2,"name":"Muslim"},
                {"id":null,"name":"Ignore. All religions are equal"}
            ],
        "castes":
            [
                {"id":3,"name":"Bhumihar","religionID":1},
                {"id":2,"name":"Brahman","religionID":1},
                {"id":5,"name":"Kayastha","religionID":1},
                {"id":6,"name":"Kurmi","religionID":1},
                {"id":7,"name":"Kushwahas","religionID":1},
                {"id":8,"name":"Other","religionID":1},
                {"id":4,"name":"Rajput","religionID":1},
                {"id":1,"name":"Yadav","religionID":1},
                {"id":null,"name":"Ignore. We all are same","religionID":0}
            ],
        "allProfileForValues":
            [
                {"id":5,"relation":"Brother"},
                {"id":2,"relation":"Daughter"},
                {"id":7,"relation":"Friend"},
                {"id":6,"relation":"Relative"},
                {"id":1,"relation":"Self"},
                {"id":4,"relation":"Sister"},
                {"id":3,"relation":"Son"}
            ],
        "genders":
            [
                {"id":2,"name":"Female"},
                {"id":1,"name":"Male"}
            ],
        "allMaritalStatus":
            [
                {"id":2,"status":"Divorved"},
                {"id":1,"status":"Single"},
                {"id":3,"status":"Widowed"},
                {"id":null,"status":"Does not matter"}
            ],
        "allEmploymentTypes":
            [
                {"id":1,"type":"Does not matter"},
                {"id":5,"type":"Must be working"},
                {"id":4,"type":"Not Working"},
                {"id":3,"type":"Own Business"},
                {"id":2,"type":"Salaried"}
            ],
        "educations":
            [
                {"id":1,"degree":"Not formally educated"},
                {"id":2,"degree":"10th education"},
                {"id":3,"degree":"High school education"},
                {"id":4,"degree":"College education (BA, MA etc)"},
                {"id":5,"degree":"Professional College education (Engineer, Doctor, CA etc)"},
                {"id":null,"degree":"Does not matter"}
            ],
        "allAccountStatus":
            [
                {"id":1,"status":"Active"},
                {"id":2,"status":"Deactive  "}
            ]
    };

    var memberUrl = "/api/members";
    $httpBackend.whenGET(memberUrl).respond(members);

    var editingRegex = new RegExp(memberUrl + "/[0-9][0-9]*", '');
    $httpBackend.whenGET(editingRegex).respond(function (method, url, data) {
        var member = {"memberId": 0};
        var parameters = url.split('/');
        var length = parameters.length;
        var id = parameters[length - 1];

        if (id > 0) {
            for (var i = 0; i < members.length; i++) {
                if (members[i].memberId == id) {
                    member = members[i];
                    break;
                }
            };
        }
        return [200, member, {}];
    });

    $httpBackend.whenPOST(memberUrl).respond(function (method, url, data) {
        var member = angular.fromJson(data);

        if (!member.memberUrl) {
                // new member Id
                member.memberId = members[members.length - 1].memberId + 1;
                members.push(member);
            }
            else {
                // Updated member
                for (var i = 0; i < members.length; i++) {
                    if (members[i].memberId == member.memberId) {
                        members[i] = member;
                        break;
                    }
                };
            }
            return [200, member, {}];
        });

        // Pass through any requests for application files
        $httpBackend.whenGET(/app/).passThrough();
}

})();