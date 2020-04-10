function initDonutGraph() {
    console.log('Loading Donut Graph...');
    var ctx = document.getElementById('donutgraph').getContext('2d');
    var chart = new Chart(ctx, {
        // The type of chart we want to create
        type: 'doughnut',

        // The data for our dataset
        data: {
            labels: ['1 or 2 Family Dwelling', 'Apartment', 'Commericial'],
            datasets: [{
                backgroundColor: [
                    'rgba(191, 63, 63, 1)',
                    'rgba(120, 162, 235, 1)',
                    'rgba(255, 206, 86, 1)',
                ],
                data: [Math.random() * 10,
                Math.random() * 10,
                Math.random() * 10
                ]
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