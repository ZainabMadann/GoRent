// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener("DOMContentLoaded", function () {
    const track = document.querySelector(".image-track");
    const images = Array.from(track.children);

    images.forEach(img => {
        let clone = img.cloneNode(true);
        track.appendChild(clone);
    });

    let speed = 0.65; //lower = slower 
    let position = 0;

    function moveImages() {
        position -= speed;
        if (position <= -track.scrollWidth / 2) {
            position = 0; 
        }
        track.style.transform = `translateX(${position}px)`;
        requestAnimationFrame(moveImages);
    }

    moveImages();
});

