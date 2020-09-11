function initReviewCount() {
    console.log("Loading Review Count...")
    var rating_count = temp_data["Rank"]["total_ratings"]
    output = [];

    if (rating_count != null) {
        rating_count = rating_count.replace('(', '')
        rating_count = rating_count.replace(')', '')
        output.push('<h4>' + rating_count.toString() + ' Customer Reviews</h4>&nbsp;');
    }
    else {
        output.push('<h4>No Customer Reviews</h4>&nbsp;');
    }

    document.getElementById("review-count").innerHTML = output.join('');
    console.log("Loaded Review Count")
}