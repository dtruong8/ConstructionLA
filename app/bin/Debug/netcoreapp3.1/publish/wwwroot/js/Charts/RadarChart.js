function initRadarChart() {
    console.log("Loading Radar Chart...");
    var ctx = document.getElementById('radarchart').getContext('2d');
    const permits = temp_data;
    const specialization = ["Bldg-Addition", "Bldg-Alter/Repair", "Bldg-Demolition",
        "Bldg-New", "Bldg-Relocation", "Electrical", "Fire Sprinkler",
        "Grading", "HVAC", "Nonbldg-Addition", "Nonbldg-Alter/Repair", "Nonbldg-New", "Plumbing",
        "Pressure Vessel", "Sign", "Swimming-Pool/Spa"];
    var temp_special = [];
    var num_per_type = {};
    var num_of_specialized_projects = [];
    for (let permit of permits) {
        var temp_type = permit["permit_type"];
        if (!num_per_type.hasOwnProperty(temp_type)) {
            temp_special.push(temp_type);
            num_per_type[temp_type] = 1;
        }
        else {
            num_per_type[temp_type] = num_per_type[temp_type] + 1;
        }
    }
    /*
    for (let i = 0; i < specialization.length; i++) {
        if (!num_per_type.hasOwnProperty(specialization[i])) {
            num_of_specialized_projects.push(0);
        }
        else {
            num_of_specialized_projects.push(num_per_type[specialization[i]]);
        }
    }*/
    for (let i = 0; i < temp_special.length; i++) {
        if (!num_per_type.hasOwnProperty(temp_special[i])) {
            num_of_specialized_projects.push(0);
        }
        else {
            num_of_specialized_projects.push(num_per_type[temp_special[i]]);
        }
    }
    var myRadarChart = new Chart(ctx, {
        type: "radar",
        data: {
            labels: temp_special,
            datasets: [{
                label: "Number of Specialized Projects",
                backgroundColor: "rgba(46, 139, 87, .2)",
                borderColor: "rgba(46, 139, 87, 1)",
                pointBackgroundColor: "rgba(46, 139, 87, 1)",
                data: num_of_specialized_projects
            }]
        },
        // Configuration options go here
        options: {
            title: {
                text: 'Specialized Project Score',
                fontSize: 18,
                fontColor: '#000000',
                position: 'top',
                display: true
            },
            legend: {
                display: true,
                position: 'bottom'
            }
        }
    });
    console.log("Successfully Loaded Radar Chart...");
}