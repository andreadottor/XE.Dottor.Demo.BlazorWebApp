// This is a JavaScript module that is loaded on demand. It can export any number of
// functions, and may import other JavaScript modules if required.

export function showPrompt(message) {
  return prompt(message, 'Type anything here');
}



// TO MAKE THE MAP APPEAR YOU MUST ADD YOUR ACCESS TOKEN FROM 
// https://account.mapbox.com
/*mapboxgl.accessToken = '{ACCESS TOKEN}';*/

export function addMapToElement(element, latitude, longitude) {
    var map = L.map(element).setView([latitude, longitude], 5);

    L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
        maxZoom: 19,
        attribution: '&copy; <a href="https://openstreetmap.org/copyright">OpenStreetMap contributors</a>'
    }).addTo(map);

    var marker = L.marker([latitude, longitude]).addTo(map);

    return map;
}

export function setMapCenter(map, latitude, longitude) {
    console.dir(map);
    map.setView([latitude, longitude], 5);
}