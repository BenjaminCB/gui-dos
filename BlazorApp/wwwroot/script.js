function initMap() {
    // The location of Uluru
    const uluru = { lat: 57.048100581464965, lng: 9.937813219576787 };

    // The map, centered at Uluru
    const map = new google.maps.Map(document.getElementById("map"), {
        zoom: 17,
        center: uluru,
    });

    // The marker, positioned at Uluru
    const marker = new google.maps.Marker({
        position: uluru,
        map: map,
    });
}
