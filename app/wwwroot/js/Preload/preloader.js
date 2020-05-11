function initPreload() {
    let progress = document.getElementById("progress");
    let datavisualization = document.getElementById("datavisualization");

    var queue = new createjs.LoadQueue(false);

    queue.on("fileload", handleFileComplete);

    queue.on("progress", event => {
        let progress = Math.floor(event.progress * 100);
        //this.progress.style.width = progress + "%";
        if (progress == 100) {
            console.log("all done");
            document.querySelector("body").style.backgroundImage = "url('/images/background/grey.png')";
            document.querySelector("body").style.backgroundRepeat = "repeat";
        }
    })
    queue.on("complete", event => {
        if (temp_data != null) {
            let response = initDataVisualization();
            if (response === 1) {
                datavisualization.classList.add("fadeIn");
            }
        }
        setTimeout(() => {
            progress.classList.add('fadeOut');
        }, 500)
    })
  
    queue.loadFile("/js/DataTable/data_table.js");
    queue.loadFile("/js/Leaflet/Map.js");
    queue.loadFile("/js/Charts/LineGraph.js");
    queue.loadFile("/js/Charts/HorizontalBarGraph.js");
    queue.loadFile("/js/Charts/DonutGraph.js");
    queue.loadFile("/js/Charts/initDataVisualization.js");

}

function handleFileComplete(event) {
    var item = event.item;
    var type = item.type;
    if (type == createjs.Types.JAVASCRIPT) {
        var preloadedScript = document.createElement("script");
        preloadedScript.src = item.src;
        document.body.appendChild(preloadedScript);
    }
}