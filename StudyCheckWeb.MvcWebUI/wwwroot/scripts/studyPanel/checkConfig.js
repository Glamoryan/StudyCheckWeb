function checkSettings() {
    var sinavlar = document.getElementsByClassName("sinavClass");
    var dersler = document.getElementsByClassName("dersClass");
    var nextBtn = document.getElementById("next");
    if (!$(sinavlar).hasClass("active")) {
        nextBtn.style.pointerEvents = "none";
        nextBtn.style.opacity = "0.6";
    }
    else {
        if ($(dersler).hasClass("active")) {
            nextBtn.style.pointerEvents = "auto";
            nextBtn.style.opacity = "1";
        }        
    }

    $(".sinavClass").on("click", function () {
        nextBtn.style.pointerEvents = "none";
        nextBtn.style.opacity = "0.6";
    });
}