function formatarData(dataJson) {
    const data = new Date(dataJson);
    const dia = String(data.getDate()).padStart(2, '0');
    const mes = String(data.getMonth() + 1).padStart(2, '0');
    const ano = data.getFullYear();
    return `${dia}/${mes}/${ano}`;
}

function pegarMesAtual() {

    // Obtém a data e hora atuais
    const agora = new Date();

    // Formata a data no formato YYYY-MM-DDThh:mm
    const mes = String(agora.getMonth() + 1)//.padStart(2, '0'); // +1 porque meses são 0-11
    const dataFormatada = `${mes}`;

    return dataFormatada;
}

function pegarAnoAtual() {

    // Obtém a data e hora atuais
    const agora = new Date();

    // Formata a data no formato YYYY-MM-DDThh:mm
    const ano = agora.getFullYear();
    const dataFormatada = `${ano}`; 

    return dataFormatada;
}

function pegarDataAtual() {

    // Obtém a data e hora atuais
    const agora = new Date();

    // Formata a data no formato YYYY-MM-DDThh:mm
    const ano = agora.getFullYear();
    const mes = String(agora.getMonth() + 1).padStart(2, '0'); // +1 porque meses são 0-11
    const dia = String(agora.getDate()).padStart(2, '0');
    const horas = String(agora.getHours()).padStart(2, '0');
    const minutos = String(agora.getMinutes()).padStart(2, '0');
    const dataFormatada = `${ano}-${mes}-${dia}`; //`${ano}-${mes}-${dia}T${horas}:${minutos}`;

    return dataFormatada;
}

function validarDtFimMenorDtIni(dtIni, dtFim)  {
    let _dtIni = dtIni.value;
    let _dtFim = dtFim.value;
    if (_dtIni && _dtFim) {
        if (new Date(_dtFim) < new Date(_dtIni)) {
            alert('A data final não pode ser anterior à data inicial.');
            return false;
        }
    }
    return true;
}