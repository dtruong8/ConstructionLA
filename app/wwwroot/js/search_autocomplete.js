
    var options = {

        url: function (phrase) {
            return "https://localhost:5001/contractor/getAllContractors";
        },
        
        getValue: function (element) {
            return element.contractors_business_name;
        },

        list: {
            match: {
                enabled:true
            }
        },

        ajaxSettings: {
            dataType: "json",
            method: "POST",
            data: {
                dataType: "json"
            }
        },

        preparePostData: function (data) {
            data.phrase = $("#contractorName").val();
            return data;
        },
    };

    $("#contractorName").easyAutocomplete(options);



