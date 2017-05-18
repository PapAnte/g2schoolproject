(function () {
    $('#bravo-button-tool-add').click(function (e) {
        e.preventDefault();

        var count = $('.bravo-tool').length;
        var text = $('#brave-tool-select option:selected').text();
        var value = $('#brave-tool-select option:selected').val();
        $('#bravo-tool-list').append('<div><div class="badge">' + text + '</div><input data-val="true" id="ToolListFromRoom' + count + '__Id" name="ToolListFromRoom[' + count + '].Id" value="' + value+'" type="hidden"><input class="bravo-tool form-control" id="ToolListFromRoom' + count + '__Name" name="ToolListFromRoom[' + count + '].Name" value="' + text +'" type="hidden"></div>');
    });
}());