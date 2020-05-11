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
                backgroundColor: [  'rgb(178,34,34,.8)'/*RED*/,
                                    'rgba(30,144,255,.8)'/*Blue*/,
                                    'rgba(255,215,0,.8)' /*YELLOW*/,
                                    'rgba(46, 139, 87,.8)'/*GREEN*/,
                                    'rgba(255,165,0,.8)' /*ORANGE*/
                ],

                data: num_of_status,
            }]
        },

        // Configuration options go here
        options: {
            title: {
                text: 'Status',
                fontSize: 18,
                fontColor: '#000000',
                position: 'top',
                display: true
            },
            legend: {
                position: 'bottom',
                display: false
            }
        }

    });
    console.log('Successfully Loaded Horizontal Bar Graph...');

}
