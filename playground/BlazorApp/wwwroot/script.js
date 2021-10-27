function initMap() {
  // The location of Uluru
  const uluru = { lat: 57.048100581464965, lng: 9.937813219576787 };
  // The map, centered at Uluru
  const map = new google.maps.Map(document.getElementById("map"), {
    zoom: 17,
    center: uluru,
  });
// const _placeId = "ChIJXQPtSR8zSUYRzzgxtALwaYc";

// var request = {
//   placeId: _placeId,
//   fields: ['name', 'rating', 'formatted_phone_number', 'geometry']
// };

// service = new google.maps.places.PlacesService(map);
// service.getDetails(request, callback);

// function callback(place, status) {
//   if (status == google.maps.places.PlacesServiceStatus.OK) {
//     createMarker(place);
//   }
// }

  // The marker, positioned at Uluru
  const marker = new google.maps.Marker({
    position: uluru,
    map: map,
  });
}
