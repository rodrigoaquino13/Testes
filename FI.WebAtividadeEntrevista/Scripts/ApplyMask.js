function applyAllMask() {
    applyMaskCpf();
}

function applyAllunMask() {
    $(".cpfMask").unmask();
}

function applyMaskCpf() {
    $(".cpfMask").mask("000.000.000-00");
}