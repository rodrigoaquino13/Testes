$(function () {
    applyAllunMask();

    applyAllMask();
});

/**
 * Testa se um CPF é válido ou não.
 * 
 * @param cpf CPF
 */
function testCPF(cpf) {

    var soma = 0;

    if (cpf === "00000000000") return false;

    for (var i = 1; i <= 9; i++)
        soma = soma + parseInt(cpf.substring(i - 1, i)) * (11 - i);

    var resto = (soma * 10) % 11;

    if ((resto === 10) || (resto === 11))
        resto = 0;

    if (resto !== parseInt(cpf.substring(9, 10)))
        return false;

    soma = 0;
    for (var i = 1; i <= 10; i++)
        soma = soma + parseInt(cpf.substring(i - 1, i)) * (12 - i);

    resto = (soma * 10) % 11;

    if ((resto === 10) || (resto === 11))
        resto = 0;

    if (resto !== parseInt(cpf.substring(10, 11)))
        return false ;

    return true;
}

$(document).on("change", "#CPF", function () {
    var cpf = $(this).val();
    cpf = cpf.replace(/[^0-9]/gi, '');

    if (cpf.length == 11) {
        if (!testCPF(cpf)) {
            $("#cpf-error-message").fadeIn();
            $("#save-button").prop("disabled", true);
        } else {
            $("#cpf-error-message").hide();
            $("#save-button").prop("disabled", false);
        }
    }
})
