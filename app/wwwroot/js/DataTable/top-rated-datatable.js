function initTopRatedDT() {
    console.log("Loading Top Rated Data Table...");
    var records = []
    for (let doc of ranked_companies) {
        var temp = [doc["contractor_business_name"], doc["business_category"], doc["rating"]];
        records.push(temp);
    }
    const star = '⭐️';
    console.log(records);
    const options = {
        columns: [
            {
                name: 'Name',
                editable: false,
                resizeable: false,
                focusable: false,
                width: 500
            },
            {
                name: 'Category',
                editable: false,
                resizeable: false,
                focusable: false,
                width: 200
            },
            {
                name: 'Ratings',
                format: value => star.repeat(value),
                width: 200
            }
        ],
        data: records,
        layout: "fixed",
        noDataMessage: "No Companies were Found",
        dynamicRowHeight: true,
    }
    console.log("This is the data in the data table");
    console.log(options["data"]);
    const datatable = new DataTable('#toprated-datatable', options);
    console.log("Successfully loaded Top Rated Data Table.");
}