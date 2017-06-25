angular.module("employeeModel").component('mainTable', {
    controller: class {
        constructor($scope, $http, employees) {
            let $ctrl = this;
            $ctrl.dataMembers = employees;
        }
    },
    templateUrl: "/Home/SampleTableTemplate"
});