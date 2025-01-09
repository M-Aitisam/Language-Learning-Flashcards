function flipCard(element) {
    element.classList.toggle("flipped");

    // Optional: Add a class for animation if required
    if (element.classList.contains("flipped")) {
        element.classList.add("flipping-animation");
    } else {
        element.classList.remove("flipping-animation");
    }
}
