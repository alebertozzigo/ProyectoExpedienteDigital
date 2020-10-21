// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    
    var i = 0;
    $('#inputState').on('click', function () {
        var j = $(this).val();
        while (i > 1) {
            $("#autor" + (i - 1)).html('');
            i--;
        }
        while (i < $(this).val()) {
            $('#autor' + i).html("<td>" + (i + 1) + "</td><td><input name='nombre" + i + "' type='text' placeholder='Nombre del Autor' class='form-control input-md'  /> </td><td><input  name='mail" + i + "' type='text' placeholder='Correo electrónico'  class='form-control input-md'></td><td><input  name='dist" + i + "' type='text' placeholder='Distribución porcentual'  class='form-control input-md'></td>");

            $('#tab_logic').append('<tr id="autor' + (i + 1) + '"></tr>');
            i++;
        }
    });

});

$(document).ready(function () {

    $('#sidebarCollapse').on('click', function () {
        $('#sidebar').toggleClass('active');
    });

});
