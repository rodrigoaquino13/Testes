function applyAllMask() {
    applyMaskCpf();
}

function applyAllunMask() {
    $(".cpfMask").unmask();
}

function applyMaskCpf() {
    $(".cpfMask").mask("000.000.000-00");
}

function validarCPF() {
    var cpf = $("#pesquisar").val();
    var cpfFormatado = cpf.split(".").join("").replace("-", "");

    testCPF(cpfFormatado) ? true : toastr.warning("CPF inválido");
}

