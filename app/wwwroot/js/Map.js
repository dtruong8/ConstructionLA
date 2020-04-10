function initMap() {
    console.log('Loading Map...');

    var Stadia_AlidadeSmooth = L.tileLayer('https://tiles.stadiamaps.com/tiles/alidade_smooth/{z}/{x}/{y}{r}.png', {
        maxZoom: 20
        /*attribution: '&copy; <a href="https://stadiamaps.com/">Stadia Maps</a>, &copy; <a href="https://openmaptiles.org/">OpenMapTiles</a> &copy; <a href="http://openstreetmap.org">OpenStreetMap</a> contributors'*/
    });

    var dtla = new L.latLng({ lat: 33.954372, lon: -118.376021 });
    var mymap = new L.map('mapid',
        {
            //Setup mymap's attributes
            center: dtla,
            zoom: 9
        });
    Stadia_AlidadeSmooth.addTo(mymap);

    console.log('Successfully Loaded Map...');
}