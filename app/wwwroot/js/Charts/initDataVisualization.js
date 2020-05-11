function initDataVisualization() {
    if (temp_data != null) {
        console.log("Loading Data Visualization...")
        initDataTable();
        initLineGraph();
        initHorizontalGraph();
        initDonutGraph();
        initMap();
        console.log("Data Visualization Ready.");
        return 1;
    }
    
}