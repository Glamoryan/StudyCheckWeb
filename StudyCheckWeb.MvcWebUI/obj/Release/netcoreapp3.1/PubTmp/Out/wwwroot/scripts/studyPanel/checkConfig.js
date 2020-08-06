const baslatButon = document.getElementById("btnBaslat");
const duraklatButon = document.getElementById("btnDuraklat");
const geriButon = document.getElementById("geri");

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

function makeVisible(pasifBtn) {
    pasifBtn.style.pointerEvents = "none";
    pasifBtn.style.opacity = "0.6";    
}

function checkButtonStatus() {
    if (!$(baslatButon).hasClass("aktif")) {
        makeVisible(geriButon);
    }

    if ($(baslatButon).hasClass("aktif")) {
        duraklatButon.style.pointerEvents = "none";
        duraklatButon.style.opacity = "0.2";
        baslatButon.style.pointerEvents = "auto";
        baslatButon.style.opacity = "1";
    }
    else if ($(duraklatButon).hasClass("aktif")) {
        baslatButon.style.pointerEvents = "none";
        baslatButon.style.opacity = "0.2";
        duraklatButon.style.pointerEvents = "auto";
        duraklatButon.style.opacity = "1";
    }    
}


