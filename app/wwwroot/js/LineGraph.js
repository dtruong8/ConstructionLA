var ctx = document.getElementById('line').getContext('2d');
var chart = new Chart(ctx, {
    // The type of chart we want to create
    type: 'line',

    // The data for our dataset
    data: {
        labels: ['2013', '2014', '2015', '2016', '2017', '2018','2019', '2020'],
        datasets: [{
            label: '# of Permits',
            backgroundColor: 'rgba(191, 63, 63, 1)',
            data: [Math.random() * 10,
                Math.random() * 10,
                Math.random() * 10,
                Math.random() * 10,
                Math.random() * 10,
                Math.random() * 10,
                Math.random() * 10,
                Math.random() * 10
            ],
        }]
    },

    // Configuration options go here
    options: {
        title:{
            text: 'Number of Permits Per Year',
            position: 'top',
            display: false
        },
    }
});