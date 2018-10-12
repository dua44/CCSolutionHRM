$(document).ready(function () {

    var table = $('#example23').DataTable({
        responsive: true,
        pagingType: "full_numbers",
        order: [[5, "desc"]],
        dom: 'Bfrtip',
        buttons: [
            'copy', 'csv', 'excel', 'pdf', 'print'
        ],

    });
    var table = $('#example').DataTable({
        responsive: true,
        dom: 'Bfrtip',
        pagingType: "full_numbers",
        order: [[5, "desc"]],
        buttons: [
            'copy', 'csv', 'excel', 'pdf', 'print'
        ]
    });

    var table = $('#sales-query').DataTable({
        responsive: true,
        dom: 'Bfrtip',
        pagingType: "full_numbers",
        order: [[1, "desc"]],
        buttons: [
            'copy', 'csv', 'excel', 'pdf', 'print'
        ]
    });

    var table = $('#sales-query-list').DataTable({
        responsive: true,        
        pagingType: "full_numbers",
        order: [[4, "desc"]],
        dom: 'Bfrtip',
        buttons: [
            'copy', 'csv', 'excel', 'pdf', 'print'
        ]
    });

    var table = $('#sales-query-detail-PartNumber').DataTable({
        responsive: true,
        pagingType: "full_numbers",
        order: [[2, "desc"]]
           
    });

});

