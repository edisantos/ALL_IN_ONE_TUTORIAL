﻿var isError = false;
function OnBeginMethod() {
    $("#labelAjaxStatus").text("Loading ....");
}
function OnFailtureMethod(error) {
    $("#labelAjaxStatus").text("Sorry, an error occured." + error.responseText);
    isError = true;
}
function OnSuccessMethod(data) {
    $("#labelAjaxStatus").text("Processed the data Successfully!");
    $("#Curso").val('');
    $("#valor").val('');
}
function OnCompleteMethod(data, status) {
    if (!isError) {
        $("#labelAjaxStatus").text("Registro Completo! ");
        $("#labelAjaxStatus").css("color","green");
        ListarCursos();
    
    }
}

function ListarCursos() {
    //Chama o método ListaClientes que vai retornar o JSON
    $.getJSON("/Ajax/ListaCursos",
        function (json) {
            var tr;
            //Anexa cada linha na tabela HTML
            for (var i = 0; i < json.length; i++) {
                tr = $('<tr/>');
                tr.append("<td>" + json[i].Curso + "</td>");
                tr.append("<td>" + json[i].valor + "</td>");
              

                $('table').append(tr);
            }
        });
}