(function() {
    "use strict";

    angular.module("app").controller("UserController", UserController);

    function UserController() {
        var uc = this;

        uc.person = {
            Name: "asdas111sd",
            Id: 123
        };
    }
})();