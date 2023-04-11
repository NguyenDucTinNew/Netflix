function increaseCount(a, b) {
    var input = b.previousElementSibling;
    var value = parseInt(input.value, 10);
    value = isNaN(value) ? 0 : value;
    value++;
    input.value = value;
}
function decreaseCount(a, b) {
    var input = b.nextElementSibling;
    var value = parseInt(input.value, 10);
    if (value > 0) {
        value = isNaN(value) ? 0 : value;
        value--;
        input.value = value;
    }
}


var total = 0;
function totalprice() {
    var priceadult = document.getElementById('price-adult').innerText;
    var pricechildren = document.getElementById('price-children').innerText;
    var quantityadult = document.getElementById('quantity-adult').value;
    var quantitychildren = document.getElementById('quantity-children').value;
    total = (priceadult * quantityadult) + (pricechildren * quantitychildren);
    document.getElementById('total_price').innerHTML = total;
}

var toggle = false;
function displaychildrenprice() {
    toggle = !toggle;
    var check = document.getElementById('quantity-children').value;
    if (check < 2) {
        document.getElementById('price-children').style.display = toggle ? "inline-block" : "none";
    }
}

var tooltipTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="tooltip"]'))
var tooltipList = tooltipTriggerList.map(function (tooltipTriggerEl) {
    return new bootstrap.Tooltip(tooltipTriggerEl)
})