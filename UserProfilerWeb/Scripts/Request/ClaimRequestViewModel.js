﻿var ClaimRequestViewModel = function (propertyId) {
    var self = this;
    debugger;
    self.model = ko.observable(new ClaimRequestModel());
    self.model().id(propertyId);
    
    if (propertyId != 0)
    {

        $.ajax({
            type: "Get",
            contentType: "application/json",
            url: baseUrl + "api/RequestAPI/GetClaimRequest/" + propertyId
        }).done(function (res) {
            debugger;
            self.model().name(res.Name);
            self.model().description(res.Description);
            self.model().bedrooms(res.Bedrooms);
            self.model().beds(res.Beds);
            self.model().accomodates(res.Accomodates);
            self.model().type(res.Type);
            self.model().address1(res.Address1);
            self.model().address2(res.Address2);
            self.model().city(res.City);
            self.model().state(res.State);
            self.model().country(res.Country);
            self.model().zip(res.Zip);
            self.model().nightPrice(res.NightPrice);
            self.model().weekPrice(res.WeekPrice);
            self.model().locality(res.Locality);           

            self.model().addedAt(res.AddedAt);
            self.model().ssn(res.SSN);
            self.model().isPetsAllowed(res.IsPetsAllowed);
            self.model().isWifiAvailable(res.IsWifiAvailable);
            self.model().isACAvailable(res.IsACAvailable);
            self.model().isLiftAvailable(res.IsLiftAvailable);
            self.model().isPrivatePoolAvailable(res.IsPrivatePoolAvailable);
            self.model().isBuzzerAvailable(res.IsBuzzerAvailable);




        }).error(function (ex) {
            debugger;
            alert("Error");
        });


    }

    

    self.PrefillData = function () {
        debugger;


        self.model().name("28 SW/2E BUTTERFIELD RD");
        self.model().description("A very good apartment for Shared Accommodation");
        self.model().bedrooms(2);
        self.model().beds(6);
        self.model().accomodates(8);
        self.model().type("House");
        self.model().address1("28 SW/2E");
        self.model().address2("BUTTERFIELD RD");
        self.model().city("Roanoke");
        self.model().state("Virginia");
        self.model().country("USA");
        self.model().zip("60199");
        self.model().nightPrice(100);
        self.model().weekPrice(500);
        self.model().locality("Roanoke");

        //self.model().addedAt(res.AddedAt);
        self.model().ssn("568923568");
      


    };


    self.add = function () {
        debugger;


        var item = ko.toJSON(self.model());
        debugger;

        $.ajax({
            type: "POST",
            contentType: "application/json",
            data: item,
            url: baseUrl + "api/RequestAPI/AddClaimRequest"
        }).done(function (res) {
            debugger;

            //window.location.href = baseUrl;
            $("#showNotification").removeClass("hide").addClass("show");

        }).error(function (ex) {
            debugger;
            alert("Error");
        });


    };

 




};

