function sonuclariGetir() {
    var lblGuvenlikKodu = document.getElementById('lbl_guvenlik_no').value;
    var txtGuvenlikKodu = document.getElementById('txtGuvenlik').value;
    if (lblGuvenlikKodu != txtGuvenlikKodu) {
        alert('Security code is wrong. Please try again.')
    }

    var tckimlik = document.getElementById('tckimlik').value;
    var basvuruNo = document.getElementById('basvuruno').value;
    var metin;
    $.getJSON("../AjaxRequest.aspx?action=SonucGoster&lang=eng&Tc=" + tckimlik + "&BasvuruNo=" + basvuruNo, function (sonuclar) {
        $.each(sonuclar, function (anahtar, deger) {
            metin = "<div class='address'><h2>Results</h2><ul class='contact-info'><li>" + deger.BildirimVatandasKarar + "</li></div>";
            var divv = document.getElementById('divSonuc');
            divv.append(metin);
        })
    });
}

function sonuclariGetirAjax() {
    var lblGuvenlikKodu = document.getElementById('lblGuvenlik').innerText;
    var txtGuvenlikKodu = document.getElementById('txtGuvenlik').value;
    if (lblGuvenlikKodu != txtGuvenlikKodu) {
        alert('Security code is wrong. Please try again.')
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
        alert('Please fill in all blanks.');
    else {
        var metin;
        $.getJSON("../AjaxRequest.aspx?action=MailGonder&lang=eng&Ad=" + name + "&Cc=" + email + "&Konu=" + subject + "&Icerik=" + message, function (sonuc) {
            alert(sonuc);            
        });
    }
}