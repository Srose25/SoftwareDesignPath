console.log("javascript succesffully uploaded!")

const menuButton = document.querySelector(".menuButton");
const menu = document.querySelector(".menu");
function toggleMenu() {
    menu.classList.toggle("hide");
}

menuButton.addEventListener("click", toggleMenu);


//Resizer
function handleResize() {
    const menu = document.querySelector(".menu");
    if (window.innerWidth > 1000){ //1000 pixels
        menu.classList.remove("hide");
    } else {
        menu.classList.add("hide");
    }
}

handleResize();
window.addEventListener("resize", handleResize)


//Dialog
const galleryImages = document.querySelectorAll(".gallery img")
galleryImages.forEach(img =>{
    img.addEventListener("click", function(){
        const dialog = document.createElement("dialog");

        const bigImage = document.createElement("img");
        bigImage.src = "images/norris-full.jpeg";
        bigImage.alt = "picture";

        const closeButton = document.createElement("button");
        closeButton.textContent = "X";
        closeButton.classList.add("close-viewer");

        dialog.appendChild(bigImage);
        dialog.appendChild(closeButton);
        document.body.append(dialog);

        dialog.showModal();

        closeButton.addEventListener("click", () => {
            dialog.close();
            dialog.remove();
        });
    });
});