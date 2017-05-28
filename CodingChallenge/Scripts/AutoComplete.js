
$.ajax({
    url: "/Titles/GetTitles",
    success: function (data) {
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
})
var GetDetail = function (id) {
    $.ajax({
        url: "/Titles/GetDetail/" + id,
        success: function (data) {
            $()
            $("#txt_Name").val(data.Name);
            $("#txt_Symbol").val(data.Symbol);
            $("#txt_Last").val(data.Last);
            $("#txt_Var").val(data.VarPer);
            $("#txt_CapMarket").val(data.CapMarket);
            $("#txt_Volume").val(data.Volume);
        }
    })
}






