function suggest() {
    var xhr;
    removeElementsByClass('autocomplete-suggestions');
    var my_autocomplete = new autoComplete({
        selector: document.getElementById("autoComplete"),
        delay: 300,
        cache: false,
        source: function (term, response) {
            try {
                xhr.abort();
            }
            catch (error) {
                console.log(error);
            }
            xhr = $.getJSON('https://localhost:5001/contractor/autocomplete?phrase=' + term, function (data) {
                response(data);
            });
        },
        // controls how suggestions are displayed
        renderItem: function (item, search) {
            search = search.replace(/[-\/\\^$*+?.()|[\]{}]/g, '\\$&');
            var re = new RegExp("(" + search.split(' ').join('|') + ")", "gi");
            return '<div class="autocomplete-suggestion" data-langname="' + item['contractors_business_name'] + '" data-val="' + search + '">' + item['contractors_business_name'].replace(re, "<b>$1</b>") + '</div>';
        },
        // A callback function that fires when a suggestion is selected by mouse click, enter, or tab.
        onSelect: function (e, term, item) {
            console.log('Item "' + item.getAttribute('data-langname') + '" selected by ' + (e.type == 'keydown' ? 'pressing enter' : 'mouse click') + '.');
            // return value to input field when selection occurs
            document.getElementById('autoComplete').value = item.getAttribute('data-langname');            
        }
    });
    
}

function removeElementsByClass(className) {
    var elements = document.getElementsByClassName(className);
    while (elements.length > 0) {
        elements[0].parentNode.removeChild(elements[0]);
    }
}