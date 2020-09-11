function initInfo() {
    console.log("Loading Contractor Information...");
    var address = null;
    var license = temp_data["License"];
    var website = temp_data["Rank"]["website"];
    let output = [];

    if (license["address"] != null){
        address = license["address"];
        if (license["city"] != null) {
            address = address + " " + license["city"];
        }
        if (license["state"] != null) {
            address = address + " " + license["state"];
        }
        if (address != null) {
            output.push('<p>Address: ' + address + '<p>');
        }
    }
    else {
        output.push('<p>Address: Not Found<p>');
    }
    if (license["license_type"] != null) {
        output.push('<p>License Type: ' + license["license_type"] + '<p>');
    }
    else {
        output.push('<p>License Type: Not Found<p>');
    }
    if (license["license_number"] != null) {
        output.push('<p>License Number: ' + license["license_number"].toString() + '<p>');
    }
    else {
        output.push('<p>License Number: Not Found<p>');
    }
    if (license["license_expire_date"] != null) {
        output.push('<p>Expiration Date: ' + license["license_expire_date"].toString() + '<p>');
    }
    else {
        output.push('<p>Expiration Date: Not Found<p>');
    }
    if (website != null) {
        output.push("<a href=" +"'" + website +"' "+ "target='_blank'>Google Business Ratings</a>")
    }

    document.getElementById("contractor-info").innerHTML = output.join('');
    console.log("Loaded Contractor Information");

}