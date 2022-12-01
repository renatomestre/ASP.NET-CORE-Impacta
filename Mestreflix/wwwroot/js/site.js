// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function playNetflixSound(baseUrl) {
    let audio = new Audio(baseUrl + '/mp3/netflix-jingle.mp3');
    audio.play();
}