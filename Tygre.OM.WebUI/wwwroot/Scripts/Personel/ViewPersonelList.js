function activePersonelCheck() {
    var input, filter, table, tr, td, i, txtValue;
    check = document.getElementById("aktifCheck");
    table = document.getElementById("personelTable");
    tr = table.getElementsByTagName("tr");


    for (i = 0; i < tr.length; i++) {
        td = tr[i].getElementsByTagName("td")[6];
        if (td) {

            if (check.checked != true)
                tr[i].style.display = "";
            else {
                txtValue = td.textContent || td.innerText;
                if (txtValue == "Active") {
                    tr[i].style.display = "";
                }
                else {
                    tr[i].style.display = "none";
                }
            }
        }
    }
}

activePersonelCheck();