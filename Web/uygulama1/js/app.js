// hamburger menü butonu için kod
const hamburger = document.getElementById("hamburger");
const menu = document.getElementById("menu");

hamburger.addEventListener("click", () => {
  // ana sayfa, css, javascript menüleri altta görünsün veya kaybolsun
  menu.classList.toggle("show");
});
