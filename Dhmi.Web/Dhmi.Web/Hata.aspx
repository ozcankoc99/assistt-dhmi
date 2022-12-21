<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Hata.aspx.cs" Inherits="Dhmi.Web.Hata" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .row {
            margin-right: 20%;
            margin-left: 20%;
        }

        .col-md-2 {
            width: 20%;
            float: left;
        }

        .col-md-3 {
            width: 66%; 
            float: left;
        }

        .thumbnail { display:inline-block;display:block;
            height: auto;
            max-width: 100%;
            padding: 4px;
            line-height: 1.428571429;
            background-color: #fff;
            border: 1px solid #ddd;
            border-radius: 4px;
            -webkit-transition: all .2s ease-in-out;
            transition: all .2s ease-in-out;
        }

            .thumbnail .caption {
                padding: 9px;
                color: #333;
            }

        .text-danger {
            color: #b94a48;
        }

        .label {
            display: inline;
            padding: .2em .6em .3em;
            font-size: 75%;
            font-weight: bold;
            line-height: 1;
            color: #fff;
            text-align: center;
            white-space: nowrap;
            vertical-align: baseline;
            border-radius: .25em;
        }

        .label-danger {
            background-color: #d9534f;
        }
    </style>
</head>
<body style="width: 100%;">
    <form id="form1" runat="server">
        <div class="row">
            <div class="thumbnail">                
                <div class="caption">
                    <div class="col-md-2">
                    <img src="../Content/Images/parasut.png" alt="erisim" width="50%" />
                </div>
                    <h3 class="text-warning">BEKLENİLMEYEN HATA!</h3>
                    <p class="text-danger">
                        Oluşan hata detayları
                                    <asp:Label ID="_hataNo" runat="server" CssClass="label label-danger"></asp:Label>
                        hata olarak kayıt altına alınmıştır, biz sürekli hata kayıtlarını kontrol ediyor ve gerekli önlemleri alıyoruz.
                                    Acil durumlarda bu ekran görüntüsünü mail atabilirsiniz.
                    </p>
                    <p>
                        <strong class="text-warning">Hata: </strong>
                        <asp:Label ID="_msg" runat="server"></asp:Label>
                    </p>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
