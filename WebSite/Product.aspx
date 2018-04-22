<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Product.aspx.cs" Inherits="Product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mitchashvim - View Products</title>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.7.1/Chart.js"></script>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
</head>

<body>
    <div class="container">


        <!-- Price History Graph -->
        <canvas id="PriceHistory">
            
        </canvas>

    </div>
    <script>

        var myValue = "<%=GraphValue[0]%>";
        var secValue = '2017';
        let priceHistory = document.getElementById('PriceHistory').getContext('2d');

        let massPopChart = new Chart(priceHistory, {
            type: 'line',
            data: {
                labels: ['01', '02', '03', '04', '05', '06', '07', '08', '09', '10', '11', '12'],
                datasets: [{
                    label: myValue,
                    data: [5.34, 5.15, 5.05, 5.38, 5.34, 5.15, 6.05, 5.38, 5.34, 5.15, 5.05, 5.38],
                    borderWidth: 1,
                    borderColor: "powderblue",
                    hoverBorderColor: '#000',
                    hoverBorderWidth: 2,
                    fill: false,
                }]
            },
            options: {
                title: {
                    display: true,
                    text: 'Price graph for the past years.'
                }
            }
        });
    </script>
</body>
</html>
