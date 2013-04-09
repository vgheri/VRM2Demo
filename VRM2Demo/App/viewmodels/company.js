define(function (require) {
    var Company = function () {
        this.id = ko.observable("");
        this.pathToLogo = ko.observable("");
        this.name = ko.observable("");
        this.activity = ko.observable("");
        this.address = ko.observable("");
        this.contacts = ko.observableArray([]);
        this.documents = ko.observableArray([]);
        this.photos = ko.observableArray([]);
    };

    return Company;
});