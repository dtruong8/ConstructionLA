function initDonutGraph() {
    console.log('Loading Donut Graph...');
    var ctx = document.getElementById('donutgraph').getContext('2d');
    const permits = temp_data;
    var buildings = [];
    var num_of_building = [];
    var buildingNnumber = {};
    for (let permit of permits) {
        if (!buildingNnumber.hasOwnProperty(permit["permit_subtype"])) {
            buildingNnumber[permit["permit_subtype"]] = 1;
            buildings.push(permit["permit_subtype"]);
        }
        else {
            buildingNnumber[permit["permit_subtype"]] = buildingNnumber[permit["permit_subtype"]] + 1;
        }
    }
    for (let i = 0; i < buildings.length; i++) {
        if (!buildingNnumber.hasOwnProperty(buildings[i])) {
            num_of_building.push(0);
        }
        else {
            num_of_building.push(buildingNnumber[buildings[i]]);
        }
    }
    var chart = new Chart(ctx, {
        // The type of chart we want to create
        type: 'doughnut',

        // The data for our dataset
        data: {
            labels: buildings,
            datasets: [{
                backgroundColor: [
                    'rgb(178,34,34,.8)'/*RED*/,
                    'rgba(30,144,255,.8)'/*Blue*/,
                    'rgba(255,215,0,.8)' /*YELLOW*/
                ],
                data: num_of_building
            }]
        },

        // Configuration options go here
        options: {
            title: {
                text: 'Permit Sub-Type',
                fontSize: 18,
                fontColor: '#000000',
                position: 'top',
                display: true
            },
            legend: {
                position: 'bottom',
                display: true
            }
        }
    });
    console.log('Successfully Loaded Donut Graph...');
}