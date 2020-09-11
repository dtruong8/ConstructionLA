function initLineGraph() {
    console.log("Loading Line Graph...");
    var ctx = document.getElementById('line').getContext('2d');
    const permits = temp_data["Records"];
    var yearsnpermit = {};
    const years = ['2013', '2014', '2015', '2016', '2017', '2018', '2019', '2020']
    const num_of_permits = [];
    for(let permit of permits) {
        var temp_year = permit["issue_date"].substring(0, 4);
        if (!yearsnpermit.hasOwnProperty(temp_year)) {
            yearsnpermit[temp_year] = 1
        }
        else {
            yearsnpermit[temp_year] = yearsnpermit[temp_year] + 1
        }
    }
    for (let i = 0; i < years.length; i++) {
        if (!yearsnpermit.hasOwnProperty(years[i])) {
            num_of_permits.push(0);
        }
        else {
            num_of_permits.push(yearsnpermit[years[i]]);
        }
    }
    var chart = new Chart(ctx, {
        // The type of chart we want to create
        type: 'line',
        // The data for our dataset
        data: {
            labels: years,
            datasets: [{
                label: '# of Permits',
                backgroundColor: 'rgba(30,144,255,1)'/*Blue*/,
                data: num_of_permits,
            }]
        },

        // Configuration options go here
        options: {
            title: {
                text: 'Number of Permits Per Year',
                fontSize: 18,
                fontColor: '#000000',
                position: 'top',
                display: false
            },
            legend: {
                display: true
            }
        }
    });
    console.log("Successfully Loaded Line Graph...");

}
