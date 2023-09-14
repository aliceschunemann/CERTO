//$(document).ready(function () {
//    $('#tabela_instituicoes').DataTable({
//        "order": [[1, "asc"]]
//    });

    
//});

//$(".submitDetalhes").click(function () {
//    var instituicaoid = $(this).data("instituicao-id");
//    alert("Clicou! " + instituicaoid);
//    $.ajax({
//        url: "/Instituicao/Detalhes",
//        type: "POST",
//        data: '{id:' + instituicaoid + '}',
//        success: function (data) {
//            $("#containerDetalhes").html(data);
//        }
//    });
//});

function detalhesInstituicao(instituicaoid) {
    console.log("Clicou em: " + instituicaoid);
    $.ajax({
        url: "/Instituicao/Detalhes",
        type: "POST",
        data: '{id:' + instituicaoid + '}',
        success: function (data) {
            $("#containerDetalhes").html(data);
        },
        error: function (error) {
            console.log(error);
        },
    });
};