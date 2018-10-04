 $(function () {
     $(".datepicker").datepicker({
         changeMonth: true,
         changeYear: true,
         yearRange: "-100:+0", // You can set the year range as per as your need
         dateFormat: 'dd-M-yy'
     });
 });