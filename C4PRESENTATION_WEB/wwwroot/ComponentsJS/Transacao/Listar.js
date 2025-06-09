// Listar

const carregarTransacao = () => {
    fetch('/Transacao/ListarJson', {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json'
        }
    })
        .then(response => response.json())
        .then(responseData => {
            let registros = document.getElementById('registros');
            registros.innerHTML = '';
            if (responseData && responseData.ret) {
                const transacao = responseData.transacao;
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
                            <th>Cadastro</th>
                            <th>Cad. Atualizado</th>
                            <th>Ações</th>
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
                            <td>
                                <button class="btn btn-primary btn-sm" onclick="showModalAtualizar('${item.guidId}')" title='Editar transação'>E</button>
                                <button class="btn btn-danger btn-sm" onclick="deletar('${item.guidId}')" title='Deletar transação'>D</button>
                                <button class="btn btn-warning btn-sm" onclick="deletar('${item.guidId}')" title='Importação dados para transação'>I</button>
                                <button class="btn btn-info btn-sm" onclick="deletar('${item.guidId}')" title='Relatório dos dados'>R</button>
                                <button class="btn btn-success btn-sm" onclick="deletar('${item.guidId}')" title='Gráfico dos dados'>G</button>
                            </td>
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
            //console.log(data)
        })
        .catch(error => {
            alert(`${error}`)
        });
}

document.addEventListener('DOMContentLoaded', carregarTransacao);