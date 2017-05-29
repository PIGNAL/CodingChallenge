
$.ajax({
    url: "/Titles/GetTitles",
    success: function (data) {
        SetupAutoComplete(data)
    }
});
var GetDetail = function (id) {
    $.ajax({
        url: "/Titles/GetDetail/" + id,
        success: function (data) {
            SetDetail(data)
        }
    })
}
var AutoAjustarTexTarea = function () {
    $(".autoHeight").each(function () {
        $(this).height(0)
        $(this).height($(this).prop('scrollHeight'))
    })
}
var SetupAutoComplete = function (data) {
    $("#txt_title").autocomplete({
        source: data,
        focus: function (event, ui) {
            $("#txt_title").val(ui.item.label);
            return false;
        },
        select: function (event, ui) {
            GetDetail(ui.item.value)
            event.preventDefault();
        }
    })
}
var SetDetail = function (data) {
    $("#txt_Descripcion").val(data.Descripcion);
    $("#txt_Detalle").val(data.Detalle);
    $("#txt_Moneda").val(data.Moneda);
    $("#txt_Simbolo").val(data.Simbolo);
    $("#txt_Tipo").val(data.Tipo);
    AutoAjustarTexTarea()
}