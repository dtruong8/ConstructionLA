var dtla = new L.latLng({ lat: 34.0101706, lon: -118.3691545 });

var basemap = new L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
    attribution: '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
});

var mymap = new L.Map('mapid', {
    center: dtla,
    zoom: 10,
    zoomControl: false
});