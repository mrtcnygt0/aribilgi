var baslik = document.getElementById("baslik");

function MesajVer2() {
  alert("Bu external script kullanımına bir şörnektir.");
}

function BaslikAlert() {
  var metin = document.getElementById("baslik").innerHTML;
  alert(metin);
}

function BaslikDegistir() {
  if (baslik.innerHTML == "Mert Can YİĞİT") {
    alert("Başlık zaten aynı");
    return;
  }
  baslik.innerHTML = "Mert Can YİĞİT";
}

function BaslikGosterGizle() {
  if (baslik.style.display == "none") {
    baslik.style.display = "block";
  } else {
    baslik.style.display = "none";
  }
}

function Hesapla() {
  var sayi1 = parseFloat(document.getElementById("sayi1").value);
  var sayi2 = parseFloat(document.getElementById("sayi2").value);
  var secim = document.getElementById("selection").value;
  var sonuc;

  if (secim === "topla") {
    sonuc = sayi1 + sayi2;
  } else if (secim === "cikar") {
    sonuc = sayi1 - sayi2;
  } else if (secim === "carp") {
    sonuc = sayi1 * sayi2;
  } else if (secim === "bol") {
    sonuc = sayi1 / sayi2;

    document.getElementById("sonuc").value = parseFloat(sonuc).toFixed(2);
    return;
  }

  document.getElementById("sonuc").value = sonuc;
}

function DegiskenlerConst() {
  const kdv = 0.2;

  // kdv = 0.3; sabitlere yeniden değer ataması yapılamaz.
}

function SwitchCase() {
  var secim = document.getElementById("secim").value;

  switch (secim) {
    case "topla":
      console.log("Toplam Seçildi");
      return;
    case "cikar":
      console.log("Çıkarma seçildi");
      return;
    case "carp":
      console.log("Çarpma seçildi");
      return;
    case "bolme":
      console.log("Bölme Seçildi");
      return;
    default:
      console.log("Hatalı Seçim");
      return;
  }
}

function ForDongusu() {
  // for döngüsü, belirli bir koşul sağlandığı sürece bir kod bloğunu tekrar tekrar çalıştırmak için kullanılır.
  var limit = prompt("Sayaç değerini giriniz...", 100);
  let toplam = 0;
  for (var i = 0; i < limit; i++) {
    console.log("Döngü " + (i + 1) + " kez çalıştı.");
    toplam += i;
  }
  alert("Toplam değeri: " + toplam);
}

function WhileDongusu() {
  // while döngüsü, belirli bir koşul sağlandığı sürece bir kod bloğunu tekrar tekrar çalıştırmak için kullanılır.
  let toplam = 0;
  var cevap = true;
  while (cevap) {
    var gelenDeger = parseFloat(prompt("Toplanacak değeri giriniz...", 100));

    if (
      gelenDeger == NaN ||
      gelenDeger == null ||
      gelenDeger.toString().trim() === ""
    ) {
      alert("Lütfen geçerli bir sayı giriniz.");
      cevap = false;
      continue;
    } else {
      toplam += gelenDeger;
      cevap = confirm("Devam etmek istiyor musunuz?");
      if (cevap != true) {
        cevap = false;
        alert("Toplam değeri: " + toplam);
      }
    }
  }
}

function DoWhileDongusu() {
  // do while döngüsü, kod bloğunu en az bir kez çalıştırır ve ardından belirli bir koşul sağlandığı sürece tekrar çalıştırır.
  let toplam = 0;
  var cevap = true;
  do {
    var gelenDeger = parseFloat(prompt("Toplanacak değeri giriniz...", 100));
    if (
      gelenDeger == NaN ||
      gelenDeger == null ||
      gelenDeger.toString().trim() === ""
    ) {
      alert("Lütfen geçerli bir sayı giriniz.");
      continue;
    } else {
      toplam += gelenDeger;
    }
    cevap = confirm("Devam etmek istiyor musunuz?");
    if (cevap != true) {
      cevap = false;
      alert("Toplam değeri: " + toplam);
    }
  } while (cevap);
}
