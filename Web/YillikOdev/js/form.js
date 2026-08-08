document.getElementById("gonder").addEventListener("click", function () {
  let isim = document.getElementById("isim").value;
  let email = document.getElementById("email").value;
  let mesaj = document.getElementById("mesaj").value;

  if (isim == "" || email == "" || mesaj == "") {
    alert("Tüm alanlar dolu olmalıdır.");
    return;
  }

  alert(isim + ", mesajınız başarıyla gönderildi.");
});
