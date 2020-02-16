
var options = {

    url: function(phrase) {
      return "https://localhost:5001/SearchContractor/getAllContractorNames?phrase="+phrase;
    },
  
    getValue: function(element) {
      return element.contractors_business_name;
    },

    ajaxSettings: {
      dataType: "json",
      method: "GET",
      data: {
        dataType: "json"
      }
    },
  
    preparePostData: function(data) {
      data.phrase = $("#contractor_business_name").val();
      return data;
    },
  
    requestDelay: 400,
  };
  
  $("#contractor_business_name").easyAutocomplete(options);