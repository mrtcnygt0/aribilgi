// hamburger menü butonu için kod
const hamburger = document.getElementById("hamburger");
const menu = document.getElementById("menu");

var deger = parseInt(document.getElementById("deger").innerHTML);

hamburger.addEventListener("click", () => {
  // ana sayfa, css, javascript menüleri altta görünsün veya kaybolsun
  menu.classList.toggle("show");
});

function btnEksi() {
  deger = document.getElementById("deger").innerHTML = deger - 1;
  console.log(deger);
}

function btnArti() {
  deger = document.getElementById("deger").innerHTML = deger + 1;
  console.log(deger);
}

function btnSifirla() {
  deger = document.getElementById("deger").innerHTML = 0;
  console.log(deger);
}
