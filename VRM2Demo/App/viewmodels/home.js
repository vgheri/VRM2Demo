//define(['services/logger'], function (logger) {
define(function (require) {
    var logger = require('services/logger');
    var Company = require('viewmodels/company');
    var router = require('durandal/plugins/router');

    var searchForm = {
        activate: activate,
        title: 'VRM2 admininistration panel',
        name: ko.observable(""),
        selectedCompany: ko.observable(),
        companies: ["Eurogiciel", "Company B", "Company C"],
        selectedActivity: ko.observable(),
        activities: ["IT services", "Activity B", "Activity C"],
        searchResults: ko.observableArray([]),
        search: search
    };    

    return searchForm;

    //#region Internal Methods
    function activate() {
        //logger.log('Home View Activated', null, 'home', true);
        //TODO Not working
        /*$('#searchResultBody tr').on("click", function () {
            var href = $(this).find("a").attr("href");
            if (href) {
                router.navigateTo(href);
            }
        });*/
        return true;
    }

    function success(data) {
        //var data = JSON.parse(json);
        var self = this;
        var company;
        var companies = [];
        if (data && data.length > 0) {
            logger.log('Search returned ' + data.length + ' results', null, 'home', true);
            $.each(data, function (index, item) {
                company = new Company();
                company.id(item.Id);
                company.name(item.Name);
                company.activity(item.Activity);
                companies.push(company);
            });
            this.searchResults(companies);
        }
        else {
            logger.log('Found no results', null, 'home', true);
        }

    }

    function search() {
        $.ajax({
            url: '/HotTowel/Search',
            contentType: 'application/json',
            dataType: 'json',
            data: { name: searchForm.name(), companyId: searchForm.selectedCompany(), activityId: searchForm.selectedActivity() },
            cache: false,
            success: $.proxy(success, searchForm),
            error: function () { logger.logError('Could not search', null, 'home', true); }
        });        
    }
    //#endregion
});