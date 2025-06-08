const carregarTransacao = () => {
    fetch('/Transacao/JsonListar', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        }
    })
        .then(response => response.json())
        .then(data => {
            const registros = document.getElementById('registros');
            registros.innerHTML = '';

            if (data && data.ret) {
                const transacao = data.transacao;
                if (transacao && transacao.length > 0) {
                    let tabela = '';
                    tabela += `<table class="table table-bordered"><caption>Total: ${transacao.length}</caption>`;
                    tabela += `<thead class="bg-light text-dark">
                        <tr>
                            <th style="width:20%">Código</th>
                            <th style="width:20%">Empresa</th>
                            <th>Mês</th>
                            <th>Ano</th>
                            <th>Período Inicial</th>
                            <th>Período Final</th>
                            <th>Data Cadastro</th>
                            <th>Data Cad. Atualizado</th>
                        </tr>
                    </thead><tbody>`;

                    transacao.forEach(item => {
                        tabela += `<tr>
                            <td>${item.guidId}</td>
                            <td>${item.empresaNome}</td>  
                            <td>${item.mes}</td>
                            <td>${item.ano}</td>
                            <td>${formatarData(item.periodoIni) ?? ''}</td>
                            <td>${formatarData(item.periodoFim) ?? ''}</td>
                            <td>${formatarData(item.transacaoDataCadastro) ?? ''}</td>
                            <td>${formatarData(item.transacaoDataAtualizacao) ?? ''}</td>
                        </tr>`;
                    });

                    tabela += '</tbody></table>';
                    registros.innerHTML = tabela;
                } else {
                    registros.innerHTML = '<div>Nenhum encontrado.</div>';
                }
            } else {
                registros.innerHTML = `<div class="text-danger">${data.output?.msg ?? 'Erro.'}</div>`;
            }
            console.log(data)
        })
        .catch(error => {
            alert(`${error}`)
        });
}

//const abrirModalCriarCliente = () => {
//    let modal = document.getElementById('modalCriarCliente');
//    fetch('/html/Cliente/Criar.html')
//        .then(response => {
//            if (!response.ok) throw new Error('Erro ao carregar o formulário');
//            return response.text();
//        })
//        .then(data => {
//            modal.innerHTML = '';
//            modal.innerHTML = data;
//            var modalInstance = new bootstrap.Modal(modal);
//            modalInstance.show();
//        })
//        .catch(error => {
//            alert(`${error}`);
//        });
//}

// Opcional: chama automaticamente ao carregar a página
document.addEventListener('DOMContentLoaded', carregarTransacao);