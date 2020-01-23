 // Create a map object called mymap
 var mymap = new L.map('mapid').setView([33.954372,-118.376021],10);
    
 // Add baselayer to mapid
 L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
     attribution: '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
 }).addTo(mymap);