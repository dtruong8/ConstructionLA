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
                    'rgba(191, 63, 63, 1)',
                    'rgba(120, 162, 235, 1)',
                    'rgba(255, 206, 86, 1)',
                ],
                data: num_of_building
            }]
        },

        // Configuration options go here
        options: {
            title: {
                text: 'Permit Sub-Type',
                position: 'top',
                display: true
            },
            legend: {
                display: false
            }
        }
    });
    console.log('Successfully Loaded Donut Graph...');
}