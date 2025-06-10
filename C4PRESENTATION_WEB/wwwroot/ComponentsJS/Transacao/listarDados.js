const _modalListarDados = document.getElementById('modalListarDados');

const showModalListarDados = (GuidId) => {
    fetch('/ComponentsHTML/Transacao/listarDados.html', {
        method: 'GET',
        headers: {
            'Accept': 'application/text',
            'Content-Type': 'application/text'
        }
    })
        .then(response => response.text())
        .then(responseData => {
            if (responseData) {
                _modalListarDados.innerHTML = '';
                _modalListarDados.innerHTML = responseData;
                carregarTransacaoDados(GuidId)
                // INI - Cria uma instância do Bootstrap / Modal caso não exista
                let _modalInstance = bootstrap.Modal.getInstance(_modalListarDados);
                if (!_modalInstance) {
                    _modalInstance = new bootstrap.Modal(_modalListarDados);
                }
                _modalInstance.show();
                // FIM
            }
        })
        .catch(error => {
            alert(`Erro ${error}`);
        })
}

if (_modalListarDados) {
    _modalListarDados.addEventListener('hidden.bs.modal', () => {
        _modalListarDados.innerHTML = '';
    });
}

const carregarTransacaoDados = (GuidId) => {
    fetch(`/Transacao/ListarTransacaoDadosJson?GuidId=${encodeURIComponent(GuidId)}`, {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json'
        }
    })
        .then(response => response.json())
        .then(responseData => {
            let registros = document.getElementById('registrosDados');
            registros.innerHTML = '';
            if (responseData && responseData.ret) {
                const transacao = responseData.transacao;
                if (transacao && transacao.length > 0) {
                    let tabela = '';
                    tabela += `<table class="table table-bordered"><caption>Total: ${transacao.length}</caption>`;
                    tabela += `<thead class="bg-light text-dark">
                        <tr>
                            <th style="width:20%">Código</th>
                            <th style="width:20%">CCusto</th>
                            <th style="width:20%">TotalCliente</th>
                            <th style="width:20%">Cadastro</th>
                            <th style="width:20%">Cad. Atualizado</th>
                        </tr>
                    </thead><tbody>`;

                    let soma = 0;

                    transacao.forEach(item => {
                        tabela += `<tr>
                            <td>${item.guidId}</td>
                            <td>${item.cCusto}</td>
                            <td>${formatarDecimalBR(item.totalCliente)}</td>
                            <td>${formatarData(item.transacaoDadosDataCadastro) ?? ''}</td>
                            <td>${formatarData(item.transacaoDadosDataAtualizacao) ?? ''}</td>
                        </tr>`;

                        soma += item.totalCliente
                    });

                    tabela += `<tr><td></td><td></td><td>Total: ${formatarDecimalBR(soma)}</td><td></td><td></td></tr>`

                    tabela += '</tbody></table>';
                    registros.innerHTML = tabela;
                } else {
                    registros.innerHTML = '<div>Nenhum encontrado.</div>';
                }
            } else {
                registros.innerHTML = `<div class="text-danger">${responseData.output?.msg ?? 'Erro.'}</div>`;
            }
            //console.log(data)
        })
        .catch(error => {
            alert(`${error}`)
        });
}