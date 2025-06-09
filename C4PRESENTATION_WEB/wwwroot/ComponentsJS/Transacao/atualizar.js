const _modalAtualizar = document.getElementById('modalAtualizar');

const showModalAtualizar = (GuidId) => {
    fetch('/ComponentsHTML/Transacao/Atualizar.html', {
        method: 'GET',
        headers: {
            'Accept': 'application/text',
            'Content-Type': 'application/text'
        }
    })
        .then(response => response.text())
        .then(responseData => {
            if (responseData) {
                _modalAtualizar.innerHTML = '';
                _modalAtualizar.innerHTML = responseData;
                carregarEmpresa()
                pegarPorId(GuidId)
                // INI - Cria uma instância do Bootstrap / Modal caso não exista
                let _modalInstance = bootstrap.Modal.getInstance(_modalAtualizar);
                if (!_modalInstance) {
                    _modalInstance = new bootstrap.Modal(_modalAtualizar);
                }
                _modalInstance.show();
                // FIM
            }
        })
        .catch(error => {
            alert(`Erro ${error}`);
        })
}

if (_modalAtualizar) {
    _modalAtualizar.addEventListener('hidden.bs.modal', () => {
        _modalAtualizar.innerHTML = '';
    });
}

const pegarPorId = (GuidId) => {
    fetch(`/Transacao/PegarPorIdJson?GuidId=${encodeURIComponent(GuidId)}`, {
        method: 'GET',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        }
    })
        .then(response => response.json())
        .then(responseData => {
            if (responseData && responseData.ret) {
                let transacao = responseData.transacao;
                if (transacao && transacao != null) {
                    document.getElementById("Id").value = transacao.id;
                    document.getElementById("GuidId").value = transacao.guidId;
                    document.getElementById("TransacaoDataCadastro").value = transacao.transacaoDataCadastro;
                    document.getElementById("TransacaoDataAtualizacao").value = transacao.transacaoDataAtualizacao;
                    document.getElementById("Mes").value = transacao.mes;
                    document.getElementById("Ano").value = transacao.ano;
                    document.getElementById("PeriodoIni").value = transacao.periodoIni.split("T")[0];
                    document.getElementById("PeriodoFim").value = transacao.periodoFim.split("T")[0];
                    document.getElementById("Empresa").value = transacao.empresaId;
                }
            } else {
                alert(`Erro. ${responseData.msg}`)
            }
        })
        .catch(error => {
            alert(`Erro ${error}`);
        })
}

const atualizar = (event) => {

    event.preventDefault();

    if (validarCamposHTML5()) {

        let id = document.getElementById("Id").value;
        let guidId = document.getElementById("GuidId").value;
        let transacaoDataCadastro = document.getElementById("TransacaoDataCadastro").value;
        let transacaoDataAtualizacao = document.getElementById("TransacaoDataAtualizacao").value;
        let mes = document.getElementById("Mes").value;
        let ano = document.getElementById("Ano").value;
        let periodoIni = document.getElementById("PeriodoIni").value;
        let periodoFim = document.getElementById("PeriodoFim").value;
        let empresa = document.getElementById("Empresa").value;

        let dados = {
            Id: id,
            GuidId: guidId,
            TransacaoDataCadastro: transacaoDataCadastro,
            TransacaoDataAtualizacao: transacaoDataAtualizacao,
            Mes: mes,
            Ano: ano,
            PeriodoIni: periodoIni,
            PeriodoFim: periodoFim,
            EmpresaId: empresa
        }

        console.log(dados)

        fetch('/Transacao/AtualizarJson', {
            method: 'PUT',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(dados)
        })
            .then(response => response.json())
            .then(responseData => {
                if (responseData && responseData.ret) {

                    alert(responseData.msg);

                    let _modalInstance = bootstrap.Modal.getInstance(_modalAtualizar);
                    if (!_modalInstance) {
                        _modalInstance = new bootstrap.Modal(_modalAtualizar);
                    }
                    _modalInstance.hide();

                    _modalAtualizar.innerHTML = '';
                    carregarTransacao();

                } else {
                    alert(responseData.msg);
                }                
            })
            .catch(error => {
                alert(error)
            })
    }
}