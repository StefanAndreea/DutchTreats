// execute this when the DOM is fully loaded
$(document).ready(function () {
    var x = 0;
    var s = "";

    console.log("Hello Pluralsight!");

    var theForm = $("#theForm");
    theForm.hide();

    // logging the clicking on the buyButton
    var button = $("#buyButton");
    button.on("click", function () {
        console.log("Buying Item");
    });

    // logging the clicking on each li in the collection productInfo, containing product-props
    var productInfo = $(".product-props li");
    productInfo.on("click", function () {
        console.log("You clicked in " + $(this).text());
    });

    var $loginToggle = $("#loginToggle");
    var $popupForm = $(".popup-form");

    // hide the login form if it's shown and vice-versa
    $loginToggle.on("click", function () {
        $popupForm.slideToggle(500);
    });
    


});