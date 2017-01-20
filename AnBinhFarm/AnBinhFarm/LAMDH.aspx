<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LAMDH.aspx.cs" Inherits="HPSHOP.LAMDH" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script language="javascript" type="text/javascript">
        function Timer(container, timeLeft) {
            // get hour, minute and second element using jQuery selector
            var hoursContainer = $(container).find('.hour');
            var minsContainer = $(container).find('.min');
            var secsContainer = $(container).find('.sec');

            // hold time left
            var currentTimeLeft = timeLeft;
            // 1 second = 1000 ms
            var secondsForTimer = 1000;
            // hold ID value return by setInterval()
            var timerInterval;

            // call setInteval() only when timeLeft is greater than 0
            if (currentTimeLeft == 0) {
                return;
            } else {
                //Call setInterval()function and store ID value to timerInterval. 
                timerInterval = setInterval(countdown, secondsForTimer);
            }

            //function being passed to setInterval()
            function countdown()
             {
                currentTimeLeft = parseInt(currentTimeLeft - secondsForTimer);
                if (currentTimeLeft == 0) 
                {
                    //stop calling countdown function by calling clearInterval()
                    clearInterval(timerInterval);
                    return;
                }
                else 
                {
                    //calculate hours left
                    var wholeSeconds = parseInt(currentTimeLeft / 1000, 10);
                    var wholeMinutes = parseInt(currentTimeLeft / 60000, 10);
                    var wholeHours = parseInt(wholeMinutes / 60, 10);
                    //calculate minutes left
                    var minutes = parseInt(wholeMinutes % 60, 10);
                    //calculate seconds left
                    var seconds = parseInt(wholeSeconds % 60, 10);
                    //prefix 0 to hour, min and second counter
                    $(hoursContainer).text((wholeHours < 10 ? "0" : "") + wholeHours + (wholeHours <= 0 ? " hr" : " hrs"));
                    $(minsContainer).text((minutes < 10 ? "0" : "") + minutes + (minutes <= 0 ? " min" : " mins"));
                    $(secsContainer).text((seconds < 10 ? "0" : "") + seconds + (seconds <= 0 ? " sec" : " secs"));
                }
            }
        }
    </script>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min.js"></script>

    <script type="text/javascript" language="javascript">
        $(document).ready(function () {
            var timeLeft = '<%=remaingTime%>';
            var timer = new Timer($('#counter'), timeLeft);
            gio.innerHTML = eval(timer);
        });
    </script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h2 id="gio"  > </h2>
    <%= remaingTime %>
    </div>
    </form>
</body>
</html>
