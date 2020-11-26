
// 目前第幾張圖 
var ShowCurrent = function () {
    /*絕對值因為如果第一張往左 會是負數*/
    var itemToShow = Math.abs(counter % itemsCount) ;
    $.each(items, function (i, item) {
        $(item).removeClass('show');
    });
    $.each(items_btn, function (i, item) {
        $(items_btn).removeClass('manual-btn-hover');
    });
    $(items_btn[itemToShow]).addClass('manual-btn-hover');
    $(items[itemToShow]).addClass('show');
};
//下一張圖
function ShowNext() {
    counter++;
    ShowCurrent();
}
//上一張圖
function ShowPrev() {
    counter--;
    ShowCurrent();
}

function showAssign(count) {
    counter = count;
    ShowCurrent();
}
