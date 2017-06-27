import sampleModuleApp from './sample-script'
import employeeModel from './script'

angular.module('myApp', [sampleModuleApp, employeeModel]);

angular.element(function () {
    angular.bootstrap(document, ['myApp']);
});