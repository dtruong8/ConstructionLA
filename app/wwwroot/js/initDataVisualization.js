function initDataVisualization() {
    if (temp_data != null) {
        console.log("Loading Data Visualization...")
        initMap();
        initDataTable();
        initLineGraph();
        initHorizontalGraph();
        initDonutGraph();
        initRadarChart();
        console.log("Data Visualization Ready.");
        return 1;
    }
    
}