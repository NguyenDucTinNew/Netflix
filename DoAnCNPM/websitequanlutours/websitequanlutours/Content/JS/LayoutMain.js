var toggle = false;
function displaySearchBar() {
    toggle = !toggle;
    document.getElementById('searchbar').style.display = toggle ? "inline-block" : "none";
}