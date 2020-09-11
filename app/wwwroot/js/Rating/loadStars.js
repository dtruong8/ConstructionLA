function initStarRatings() {
    console.log("Loading Star Rating...");
    var total_stars = 5.0;
    var rating = Math.round(parseFloat(temp_data["Rank"]["rating"]) * 2) / 2;
    let output = [];
    var temp = rating;
    if (rating > 0) {
        for (var i = 0; i < total_stars; i++) {
            if (temp >= 1) {
                output.push('<i class="fa fa-star" aria-hidden="true" style="color: gold;"></i>&nbsp;');
                temp = temp - 1;
            }
            else if (temp >= .5) {
                output.push('<i class="fa fa-star-half" aria-hidden="true" style="color: gold;"></i>&nbsp;');
                temp = temp - .5
            }
            else {
                output.push('<i class="fa fa-star" aria-hidden="true"></i>&nbsp;');
            }
        }
        output.push('<span><b>' + rating.toString() + '</b></span>');
    }
    else {
        for (var i = 0; i < total_stars; i++) {
            output.push('<i class="fa fa-star" aria-hidden="true"></i>&nbsp;');
        }
        output.push('<span><b> 0 </b></span>');
    }

    console.log("Loaded Star Rating");

    document.getElementById("stars").innerHTML = output.join('');

}

