var sampleModuleApp = angular.module("sampleModule", []);
sampleModuleApp.component('sampleTable', {
    controller: class {
        constructor($scope, $http) {
            let $ctrl = this;
            $ctrl.employees = $scope.$ctrl.membersDetails;
        }
        $onInit() {
            let $ctrl = this;
            $ctrl.employees = $ctrl.membersDetails;
        }
    },
    bindings: {
        membersDetails: "<",
        sampleData: "@"
    },
    templateUrl: "/Sample/SampleTableTemplate"
});
