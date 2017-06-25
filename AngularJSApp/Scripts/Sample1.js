var myApp = angular.module("myApp", [])
    .directive('expandCollapse', function () {
        return {
            restrict: 'E',
            transclude: true,
            scope: { linkText: '@' },
            template: '<div style="border: 1px solid black;">' +
                        '<div style="background-color:green;"><a href="#" ng-click-"myFunc()">{{linkText}}</a></div>' +
                        '<div id="containerId" ng-transclude></div>' +
                        '<span>{{count}}</span>' +
                      '</div>'
        };
    })
  .controller('ExpandCollapseCtrl', ['$scope', function ($scope) {
      $scope.count = 0;
      $scope.myFunc = function () {
          $scope.count++;
      };
  }]);