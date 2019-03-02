function duyetstudent(id) {
    //alert('!!id ' + id)
    var request = new XMLHttpRequest();
    var url = "/Home/Duyetkhoahoc/"+id;
    var method = "POST";
    request.open(method, url);
    request.send();
}