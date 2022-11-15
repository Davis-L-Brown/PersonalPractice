var character = document.getElementById("character");
var block = document.getElementById("block");
var checkDead = setInterval(function () {
    var charTop = parseInt(window.getComputedStyle(character).getPropertyValue("top"));
    var blockLeft = parseInt(window.getComputedStyle(block).getPropertyValue("left"));
    if ((blockLeft < 20 && blockLeft > 0) && (charTop >= 130)) {
        block.style.animation = "none";
        block.style.display = "none";
        alert("You Lose");
    }
}, 10);

window.onkeypress = function (e) {
    if (e.keyCode == 32) { jump(); }
}

function jump() {
  if(character.classlist != "animate"){
    character.classList.add("animate")
  }
  setTimeout(function(){
    character.classList.remove("animate");},500);
}



