<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Dolphin.aspx.cs" Inherits="Dolphin" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cá heo bám theo chuột</title>
    <style type="text/css">
        body {
            background-color: #ccefff;
            overflow: hidden;
            margin: 0;
            padding: 0;
        }
        #dolphin {
            position: absolute;
            width: 100px;
            height: 50px;
            background: url('dolphin.png') no-repeat center center;
            background-size: contain;
            pointer-events: none;
        }
    </style>
    <script type="text/javascript">
        window.onload = function () {
            var dolphin = document.getElementById('dolphin');
            var x = 200, y = 200;
            var speed = 0.1; // 0.1 càng nhỏ càng mượt

            document.addEventListener('mousemove', function (e) {
                // cập nhật vị trí mục tiêu
                targetX = e.clientX;
                targetY = e.clientY;
            });

            var targetX = x;
            var targetY = y;

            function animate() {
                x += (targetX - x) * speed;
                y += (targetY - y) * speed;
                dolphin.style.left = (x - dolphin.offsetWidth / 2) + 'px';
                dolphin.style.top = (y - dolphin.offsetHeight / 2) + 'px';
                requestAnimationFrame(animate);
            }
            animate();
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="dolphin"></div>
    </form>
</body>
</html>
