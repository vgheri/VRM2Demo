define(function (require) {
    var logger = require('services/logger');
    var Company = require('viewmodels/company');

    var general = {
        activities: [],
        selectedActivity: ko.observable(""),
        updateGeneralInfo: function () {
            // get only vendor data from general tab and send them to the server
        }
    };

    var vm = {
        activate: activate,
        title: 'Details View',
        vendor: new Company(),
        generalTab: general
    };

    return vm;

    //#region Internal Methods
    function activate(data) {
        logger.log('Vendor id ' + data.id, null, 'details', true);
        initialise(data.id);        
        return true;
    }

    function initialise(id) {
        getVendor(id);
    }

    function getVendor(id) {
        var promise = $.ajax({
            url: '/HotTowel/GetVendor',
            contentType: 'application/json',
            dataType: 'json',
            data: { id: id },
            cache: false,
            success: $.proxy(success, vm),
            error: function (err) {
                logger.logError('Could not retrieve vendor data. ' + err, null, 'vendor', true);
            }
        });
    }

    function success(data) {
        this.generalTab.selectedActivity(data.Vendor.Activity);
        this.generalTab.activities = data.Activities;
        populateVendor(this.vendor, data.Vendor);
    }

    function populateVendor(vendor, data) {
        vendor.id(data.Id);
        vendor.name(data.Name);
        vendor.activity(data.Activity);
        vendor.address(data.Address);
        vendor.pathToLogo(data.PathToLogo);
        vendor.contacts(data.Contacts);
    }
    //#endregion
});