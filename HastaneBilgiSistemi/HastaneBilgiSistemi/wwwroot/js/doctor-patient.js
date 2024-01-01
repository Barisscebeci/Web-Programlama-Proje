function getHastalarByDoktor(doktorId) {
    $.ajax({
        url: '/Doctor/GetPatientsByDoctor/' + doktorId,
        type: 'GET',
        success: function (hastalar) {
            // Hastalar listesi ile ilgili işlemler
        },
        error: function (hata) {
            // Hata durumunda işlemler
        }
    });
}