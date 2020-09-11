function initPreload_TopRated() {
    let progress = document.getElementById("progress");
    let datavisualization = document.getElementById("TopRated");

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
        if (ranked_companies != null) {
            let response = initTopRated();
            if (response === 1) {
                datavisualization.classList.add("fadeIn");
            }
        }
        setTimeout(() => {
            progress.classList.add('fadeOut');
        }, 500)
    })
    queue.loadFile("/js/DataTable/top-rated-datatable.js");
    queue.loadFile("/js/initTopRated.js");

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