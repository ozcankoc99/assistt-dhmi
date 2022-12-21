function sonuclariGetir() {
    var lblGuvenlikKodu = document.getElementById('lbl_guvenlik_no').value;
    var txtGuvenlikKodu = document.getElementById('txtGuvenlik').value;
    if (lblGuvenlikKodu != txtGuvenlikKodu) {
        alert('Güvenlik Kodunu yanlış girdiniz!')
    }

    var tckimlik = document.getElementById('tckimlik').value;
    var basvuruNo = document.getElementById('basvuruno').value;
    var metin;
    $.getJSON("AjaxRequest.aspx?action=SonucGoster&lang=tr&Tc=" + tckimlik + "&BasvuruNo=" + basvuruNo, function (sonuclar) {
        $.each(sonuclar, function (anahtar, deger) {
            metin = "<div class='address'><h2>Sonuçlar</h2><ul class='contact-info'><li>" + deger.BildirimVatandasKarar + "</li></div>";
            var divv = document.getElementById('divSonuc');
            divv.append(metin);
        })
    });
}

function sonuclariGetirAjax() {
    var lblGuvenlikKodu = document.getElementById('lblGuvenlik').innerText;
    var txtGuvenlikKodu = document.getElementById('txtGuvenlik').value;
    if (lblGuvenlikKodu != txtGuvenlikKodu) {
        alert('Güvenlik Kodunu yanlış girdiniz!')
    }
    else {
        var tckimlik = document.getElementById('tckimlik').value;
        var basvuruno = document.getElementById('basvuruno').value;
        if (tckimlik != '' && basvuruno != '') {
            var myData = null;
            param = JSON.stringify({ tckimlik: tckimlik, basvuruno: basvuruno });

            $.ajax({
                type: "POST",
                url: "SonucGoster",
                async: false,
                data: param,
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    $("#sonuclar").text(response.d);
                },
                failure: function (response) {
                    alert(response.d);
                }
            });
        }
        else return;
    }
};

function mailGonder() {
    var name = document.getElementById('name').value;
    var email = document.getElementById('email').value;
    var subject = document.getElementById('subject').value;
    var message = document.getElementById('message').value;

    if (name == '' || email == '' || subject == '' || message == '')
        alert('Alanları eksiksiz doldurunuz!');
    else {
        var metin;
        $.getJSON("AjaxRequest.aspx?action=MailGonder&lang=tr&Ad=" + name + "&Cc=" + email + "&Konu=" + subject + "&Icerik=" + message, function (sonuc) {
            alert(sonuc);
        });
    }
}


var tagsToReplace = {
    '&': '&amp;',
    '<': '&lt;',
    '>': '&gt;',
  	' " ': '&quot',
  	' ‘ ': '&#x27',
  	' / ': '&#x2F'
};

function replaceTag(tag) {
    return tagsToReplace[tag] || tag;
}

function safe_tags_replace(str) {
    return str.replace(/[&<>]/g, replaceTag);
}