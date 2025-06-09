const _modalCriar = document.getElementById('modalCriar');

const showModalCriar = () => {
    fetch('/ComponentsHTML/Transacao/Criar.html', {
        method: 'GET',
        headers: {
            'Accept': 'application/text',
            'Content-Type': 'application/text'
        }
    })
        .then(response => response.text())
        .then(responseData => {
            if (responseData) {
                _modalCriar.innerHTML = '';
                _modalCriar.innerHTML = responseData;
                carregarMes()
                carregarAno()
                carregarDatas()
                carregarEmpresa()
                // INI - Cria uma instância do Bootstrap / Modal caso não exista
                let _modalInstance = bootstrap.Modal.getInstance(_modalCriar);
                if (!_modalInstance) {
                    _modalInstance = new bootstrap.Modal(_modalCriar);
                }
                _modalInstance.show();
                // FIM
            }
        })
        .catch(error => {
            alert(`Erro ${error}`);
        })
}

if (_modalCriar) {
    _modalCriar.addEventListener('hidden.bs.modal', () => {
        _modalCriar.innerHTML = '';
    });
}

//document.querySelectorAll('.modal').forEach(modal => {
//    modal.addEventListener('hidden.bs.modal', () => {
//        modal.innerHTML = '';
//    });
//});

const _btnShowModalCriar = document.getElementById('btnShowModalCriar')
_btnShowModalCriar.addEventListener('click', showModalCriar)

const carregarMes = () => {
    let mesAtual = pegarMesAtual();
    let mes = document.getElementById("Mes");
    if (mes) mes.value = mesAtual;
}

const carregarAno = () => {
    let anoAtual = pegarAnoAtual();
    let ano = document.getElementById("Ano");
    if (ano) ano.value = anoAtual;
}

const carregarDatas = () => {
    let dataAtual = pegarDataAtual();
    let periodoIni = document.getElementById('PeriodoIni');
    if (periodoIni) periodoIni.value = dataAtual;
    let periodoFim = document.getElementById('PeriodoFim');
    if (periodoFim) periodoFim.value = dataAtual;
}

const carregarEmpresa = () => {
    let select = document.getElementById('Empresa'); // Verifica antes por ser um campo dinâmico
    if (select) {
        fetch('/Transacao/ListarEmpresaJson', {
            method: 'GET',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            }
        })
            .then(response => response.json())
            .then(responseData => {
                select.innerHTML = '';
                if (responseData && responseData.ret) {
                    const empresa = responseData.empresa

                    let option = document.createElement('option');
                    option.value = "";
                    option.textContent = "Selecione.";
                    select.appendChild(option);

                    if (empresa && empresa.length > 0) {
                        empresa.forEach(item => {
                            let option = document.createElement('option');
                            option.value = item.id;
                            option.textContent = item.nome;
                            select.appendChild(option);
                        });
                    }
                }
            })
            .catch(error => {
                alert(`Erro. ${error}`);
            });
    }
}

const validarDataFim = () => {
    let periodoIni = document.getElementById('PeriodoIni');
    let periodoFim = document.getElementById('PeriodoFim');
    let ret = validarDtFimMenorDtIni(periodoIni, periodoFim)
    if (!ret) {
        alert('A data final não pode ser anterior à data inicial.');
        periodoFim.value = periodoIni.value; // Se inválido, define a data final como a inicial
    }
}

const validarCamposHTML5 = () => {
    let cond = true;

    let mes = document.getElementById('Mes');
    if (!mes.checkValidity()) {        
        mes.reportValidity(); // exibe a mensagem de validação
        cond = false;
    } 

    let ano = document.getElementById('Ano');
    if (!ano.checkValidity()) {
        ano.reportValidity();
        cond = false;
    }

    let periodoIni = document.getElementById('PeriodoIni');
    if (!periodoIni.checkValidity()) {
        periodoIni.reportValidity(); 
        cond = false;
    }

    let periodoFim = document.getElementById('PeriodoFim');
    if (!periodoFim.checkValidity()) {
        periodoFim.reportValidity();
        cond = false;
    }

    let empresa = document.getElementById('Empresa');
    if (!empresa.checkValidity()) {
        empresa.reportValidity();
        cond = false;
    }

    return cond;
}

const Criar = (event) => {
    event.preventDefault()

    if (validarCamposHTML5()) {    

    let mes = document.getElementById('Mes').value;
    let ano = document.getElementById('Ano').value;
    let periodoIni = document.getElementById('PeriodoIni').value;
    let periodoFim = document.getElementById('PeriodoFim').value;
    let empresa = document.getElementById('Empresa').value;

    let dados = {
        Mes: parseInt(mes),
        Ano: parseInt(ano),
        PeriodoIni: periodoIni,
        PeriodoFim: periodoFim,
        EmpresaId: parseInt(empresa)
    }

    fetch('/Transacao/CriarJson', {
        method: 'POST',
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

                let _modalInstance = bootstrap.Modal.getInstance(_modalCriar);
                if (!_modalInstance) {
                    _modalInstance = new bootstrap.Modal(_modalCriar);
                }
                _modalInstance.hide();

                _modalCriar.innerHTML = '';
                carregarTransacao();
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

                /*

                TODO
                
                <input type="text" id="mes" required>
<button onclick="validarCampo()">Enviar</button>

<script>
function validarCampo() {
  const input = document.getElementById("mes");

  if (input.value === "") {
    input.setCustomValidity("Por favor, preencha o campo Mês.");
  } else {
    input.setCustomValidity(""); // limpa mensagens anteriores
  }

  input.reportValidity(); // mostra a mensagem se o campo estiver inválido
}
</script>
                
                */