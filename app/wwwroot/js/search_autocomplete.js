var ContractorNames = [];
$.ajax({
    url: 'https://localhost:5001/SearchContractor/getAllContractorNames',
    method: 'get',
    dataType: 'json',
    success: function (data) {
        JSON.stringify(data);
        for (var i = 0; i < data.length; i++) {
            ContractorNames.push(data[i].contractors_business_name);
        }
        alert(ContractorNames[0]);
    },
    error: function (err) {
        alert(err);
    }
});

function getListNames() {
    var tags = ContractorNames
    $("#contractor_business_name").autocomplete({
        source: tags
    });
}

