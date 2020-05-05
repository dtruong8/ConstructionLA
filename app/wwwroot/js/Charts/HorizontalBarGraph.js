function initHorizontalGraph() {
    console.log('Loading Horizontal Bar Graph...');
    var ctx = document.getElementById('horizontalbargraph').getContext('2d');
    const permits = temp_data;
    var statuses = [];
    var num_of_status = [];
    var statusNnumber = {};
    for (let permit of permits) {
        if (!statusNnumber.hasOwnProperty(permit["status"])) {
            statusNnumber[permit["status"]] = 1;
            statuses.push(permit["status"]);
        }
        else {
            statusNnumber[permit["status"]] = statusNnumber[permit["status"]] + 1;
        }
    }
    for (let i = 0; i < statuses.length; i++) {
        if (!statusNnumber.hasOwnProperty(statuses[i])) {
            num_of_status.push(0);
        }
        else {
            num_of_status.push(statusNnumber[statuses[i]]);
        }
    }
    var chart = new Chart(ctx, {
        // The type of chart we want to create
        type: 'horizontalBar',

        // The data for our dataset
        data: {
            labels: statuses,
            datasets: [{
                backgroundColor: [  'rgba(245,230,99,1)',
                                    'rgba(156,56,72,1)',
                                    'rgba(23,96,135,1)'
                ],

                data: num_of_status,
            }]
        },

        // Configuration options go here
        options: {
            title: {
                text: 'Status',
                position: 'top',
                display: true
            },
            legend: {
                display: false
            }
        }

    });
    console.log('Successfully Loaded Horizontal Bar Graph...');

}
