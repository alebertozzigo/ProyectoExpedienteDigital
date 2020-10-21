// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {

   

    var i = 0;
    var i2 = 0;
    var i3 = 0;
    
    //function for the select in the Libros section
    $('#selectLibros').on('click', function () {
        var j = $(this).val();
        while (i2 > 0) {
            $("#autor" + (i2 - 1)).html('');
            i2--;
        }
        while (i2 < $(this).val()) {
            $('#autor' + i2).html("<td>" + (i2 + 1) + "</td><td><input name='nombre" + i2 + "' type='text' placeholder='Capítulo o Sección' class='form-control input-md'  /> </td> \
                <td rowspan='1'><input type='button' value='Agregar Autor' id='button' class='btn btn-primary' onclick='addNewOption(" + i2 + ")'> \
                <input type='button' value='Remover Autor' id='button' class='btn btn-danger' onclick='removeOption(" + i2 + ")'> </td > \
              ");


            $('#tab_logic').append('<tr id="autor' + (i2 + 1) + '"></tr>');
            i2++;
        }


    });

    //function for the select in the Articulos section
    $('#selectArticulos').on('click', function () {
        
        var j = $(this).val();
        while (i3 > 1) {
            $("#autor" + (i3 - 1)).html('');
            i3--;
        }
        while (i3 < $(this).val()) {
            $('#autor' + i3).html("<td>" + (i3 + 1) + "</td><td><input name='nombre" + i3 + "' type='text' placeholder='Nombre del Autor' class='form-control input-md'  /> </td><td><input  name='mail" + i3 + "' type='text' placeholder='Correo electrónico'  class='form-control input-md'></td><td><input  name='dist" + i3 + "' type='text' placeholder='Distribución porcentual'  class='form-control input-md'></td>");

            $('#tab_logic').append('<tr id="autor' + (i3 + 1) + '"></tr>');
            i3++;
        }
    });

    //function for the select in the Desarrollo de Software section
    $('#selectDesarrollo').on('click', function () {
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


/*function to remove an author*/
var contador1 = 0;
function removeOption(value) {
    console.log(value);
    
        var rows = document.getElementById("autor" + value).getElementsByClassName("form-control input-group");
        rows[value + 1].remove();
        var rows = document.getElementById("autor" + value).getElementsByClassName("form-control input-group");
        rows[value + 1].remove();
   
    
}

/*function for the Add author in Libros section*/
var contador = 0;
function addNewOption(value) {
    console.log(value);
    
    var rows = document.getElementById("tab_logic").getElementsByTagName("tr");

    
    
    var element = document.createElement('input');
    element.setAttribute("type", "text");
    element.setAttribute("class", "form-control input-group");
    element.setAttribute("id", "nombreAutor" + contador);
    element.setAttribute("placeholder", "Nombre Autor");
    

    rows[value + 1].append(element);  

    var element = document.createElement('input');
    element.setAttribute("type", "text");
    element.setAttribute("class", "form-control input-group");
    element.setAttribute("id", "correo" + contador);
    element.setAttribute("placeholder", "Correo");

    rows[value + 1].append(element);  

    
}




