function getListNames() {
    let name = document.getElementById("contractor_business_name").value;

    if (name.length > 1) {
        $("contractor_business_name").autocomplete({
            source: "https://localhost5001/SearchContractor/getAllContractorNames " + name
        });
    }
}


