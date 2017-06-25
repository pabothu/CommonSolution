var app = angular.module("sampleModule", []);
app.component('sample-data', {
    controller: class {
        constructor($scope, $http, employees) {
            let $ctrl = this;
            $ctrl.dataMembers = employees;
        }
    },
    templateUrl: "/Home/SampleTableTemplate"
});