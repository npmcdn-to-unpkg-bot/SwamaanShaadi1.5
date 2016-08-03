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

    var allLookupData = 
    {
        "districts":
            [
                {"Id":1,"name":"Madhubani","stateID":1},
                {"Id":null,"name":"","stateID":0}],
        "states":
            [
                {"Id":1,"name":"Bihar","countryID":1}
            ],
        "countries":
            [
                {"Id":1,"name":"India"}
            ],
        "religions":
            [
                {"Id":1,"name":"Hindu"},
                {"Id":2,"name":"Muslim"},
                {"Id":null,"name":"Ignore. All religions are equal"}
            ],
        "castes":
            [
                {"Id":3,"name":"Bhumihar","religionID":1},
                {"Id":2,"name":"Brahman","religionID":1},
                {"Id":5,"name":"Kayastha","religionID":1},
                {"Id":6,"name":"Kurmi","religionID":1},
                {"Id":7,"name":"Kushwahas","religionID":1},
                {"Id":8,"name":"Other","religionID":1},
                {"Id":4,"name":"Rajput","religionID":1},
                {"Id":1,"name":"Yadav","religionID":1},
                {"Id":null,"name":"Ignore. We all are same","religionID":0}
            ],
        "allProfileForValues":
            [
                {"Id":5,"relation":"Brother"},
                {"Id":2,"relation":"Daughter"},
                {"Id":7,"relation":"Friend"},
                {"Id":6,"relation":"Relative"},
                {"Id":1,"relation":"Self"},
                {"Id":4,"relation":"Sister"},
                {"Id":3,"relation":"Son"}
            ],
        "genders":
            [
                {"Id":2,"name":"Female"},
                {"Id":1,"name":"Male"}
            ],
        "allMaritalStatus":
            [
                {"Id":2,"status":"Divorved"},
                {"Id":1,"status":"Single"},
                {"Id":3,"status":"Widowed"},
                {"Id":null,"status":"Does not matter"}
            ],
        "allEmploymentTypes":
            [
                {"Id":1,"type":"Does not matter"},
                {"Id":5,"type":"Must be working"},
                {"Id":4,"type":"Not Working"},
                {"Id":3,"type":"Own Business"},
                {"Id":2,"type":"Salaried"}
            ],
        "educations":
            [
                {"Id":1,"degree":"Not formally educated"},
                {"Id":2,"degree":"10th education"},
                {"Id":3,"degree":"High school education"},
                {"Id":4,"degree":"College education (BA, MA etc)"},
                {"Id":5,"degree":"Professional College education (Engineer, Doctor, CA etc)"},
                {"Id":null,"degree":"Does not matter"}
            ],
        "allAccountStatus":
            [
                {"Id":1,"status":"Active"},
                {"Id":2,"status":"Deactive  "}
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