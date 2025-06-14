const _modalCriarLoteDados = document.getElementById('modalCriarLoteDados');

const showModalImportarDados = (Id) => {
    fetch('/ComponentsHTML/Transacao/criarLoteDados.html', {
        method: 'GET',
        headers: {
            'Accept': 'application/text',
            'Content-Type': 'application/text'
        }
    })
        .then(response => response.text())
        .then(responseData => {
            if (responseData) {
                _modalCriarLoteDados.innerHTML = '';
                _modalCriarLoteDados.innerHTML = responseData;
                document.getElementById('TransacaoId').value = Id;
                let _modalInstance = bootstrap.Modal.getInstance(_modalCriarLoteDados);
                if (!_modalInstance) {
                    _modalInstance = new bootstrap.Modal(_modalCriarLoteDados);
                }
                _modalInstance.show();
            }
        })
        .catch(error => {
            alert(`Erro ${error}`);
        })
}

if (_modalCriarLoteDados) {
    _modalCriarLoteDados.addEventListener('hidden.bs.modal', () => {
        _modalCriarLoteDados.innerHTML = '';
    });
}

const validarCamposHTML5Lote = () => {
    let cond = true;

    let nomeSheet = document.getElementById('NomeSheet');
    if (!nomeSheet.checkValidity()) {
        nomeSheet.reportValidity(); 
        cond = false;
    }

    let arquivo = document.getElementById('Arquivo');
    if (!arquivo.checkValidity()) {
        arquivo.reportValidity();
        cond = false;
    }

    return cond;
}

const criarLoteDados = (event) => {
    event.preventDefault()

    if (validarCamposHTML5Lote()) {

        let arquivo = document.getElementById('Arquivo').files[0];
        let nomeSheet = document.getElementById('NomeSheet').value;
        let transacaoId = document.getElementById('TransacaoId').value;        

        const formData = new FormData();
        formData.append('Arquivo', arquivo);
        formData.append('NomeSheet', nomeSheet);
        formData.append('TransacaoId', parseInt(transacaoId));

        fetch('/Transacao/CriarLoteTransacaoDadosJson', {
            method: 'POST',
            body: formData
        })
            .then(response => response.json())
            .then(responseData => {
                if (responseData && responseData.ret) {
                    alert(responseData.msg);

                    let _modalInstance = bootstrap.Modal.getInstance(_modalCriarLoteDados);
                    if (!_modalInstance) {
                        _modalInstance = new bootstrap.Modal(_modalCriarLoteDados);
                    }
                    _modalInstance.hide();

                    _modalCriarLoteDados.innerHTML = '';
                }
                else {
                    alert(`Erro response: ${responseData.msg}`);
                }
            })
            .catch(error => {
                alert(`Erro ${error}`);
            })
    }
}