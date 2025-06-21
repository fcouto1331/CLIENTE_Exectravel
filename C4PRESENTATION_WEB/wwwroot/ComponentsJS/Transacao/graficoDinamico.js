const carregarNSolicitante = () => {
    fetch(`/BasePopulate/ListarNSolicitanteJson?GuidId=${encodeURIComponent(_transacaoId)}`, {
        method: 'GET',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        }
    })
        .then(response => response.json())
        .then(responseData => {
            let select = document.getElementById('NSolicitante');
            select.innerHTML = '';
            if (responseData && responseData.ret) {
                const basePopulate = responseData.basePopulate
                let option = document.createElement('option');
                if (basePopulate && basePopulate.length > 0) {
                    basePopulate.forEach(item => {
                        let option = document.createElement('option');
                        option.value = item.bValue;
                        option.textContent = item.bText;
                        select.appendChild(option);
                    });
                }

                $('#NSolicitante').multiselect('rebuild'); // Quando o select for dinâmico
            }
        })
        .catch(error => {
            alert(`Erro. ${error}`);
        });
}

const carregarNAutorizacaoCartao = () => {
    fetch(`/BasePopulate/ListarNAutorizacaoCartaoJson?GuidId=${encodeURIComponent(_transacaoId)}`, {
        method: 'GET',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        }
    })
        .then(response => response.json())
        .then(responseData => {
            let select = document.getElementById('NAutorizacaoCartao');
            select.innerHTML = '';
            if (responseData && responseData.ret) {
                const basePopulate = responseData.basePopulate
                let option = document.createElement('option');
                if (basePopulate && basePopulate.length > 0) {
                    basePopulate.forEach(item => {
                        let option = document.createElement('option');
                        option.value = item.bValue;
                        option.textContent = item.bText;
                        select.appendChild(option);
                    });
                }

                $('#NAutorizacaoCartao').multiselect('rebuild');
            }
        })
        .catch(error => {
            alert(`Erro. ${error}`);
        });
}

const carregarNReserva = () => {
    fetch(`/BasePopulate/ListarNReservaJson?GuidId=${encodeURIComponent(_transacaoId)}`, {
        method: 'GET',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        }
    })
        .then(response => response.json())
        .then(responseData => {
            let select = document.getElementById('NReserva');
            select.innerHTML = '';
            if (responseData && responseData.ret) {
                const basePopulate = responseData.basePopulate
                let option = document.createElement('option');
                if (basePopulate && basePopulate.length > 0) {
                    basePopulate.forEach(item => {
                        let option = document.createElement('option');
                        option.value = item.bValue;
                        option.textContent = item.bText;
                        select.appendChild(option);
                    });
                }

                $('#NReserva').multiselect('rebuild');
            }
        })
        .catch(error => {
            alert(`Erro. ${error}`);
        });
}

const carregarNAprovador = () => {
    fetch(`/BasePopulate/ListarNAprovadorJson?GuidId=${encodeURIComponent(_transacaoId)}`, {
        method: 'GET',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        }
    })
        .then(response => response.json())
        .then(responseData => {
            let select = document.getElementById('NAprovador');
            select.innerHTML = '';
            if (responseData && responseData.ret) {
                const basePopulate = responseData.basePopulate
                let option = document.createElement('option');
                if (basePopulate && basePopulate.length > 0) {
                    basePopulate.forEach(item => {
                        let option = document.createElement('option');
                        option.value = item.bValue;
                        option.textContent = item.bText;
                        select.appendChild(option);
                    });
                }

                $('#NAprovador').multiselect('rebuild');
            }
        })
        .catch(error => {
            alert(`Erro. ${error}`);
        });
}

const carregarNMotivoDaViagem = () => {
    fetch(`/BasePopulate/ListarNMotivoDaViagemJson?GuidId=${encodeURIComponent(_transacaoId)}`, {
        method: 'GET',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        }
    })
        .then(response => response.json())
        .then(responseData => {
            let select = document.getElementById('NMotivoDaViagem');
            select.innerHTML = '';
            if (responseData && responseData.ret) {
                const basePopulate = responseData.basePopulate
                let option = document.createElement('option');
                if (basePopulate && basePopulate.length > 0) {
                    basePopulate.forEach(item => {
                        let option = document.createElement('option');
                        option.value = item.bValue;
                        option.textContent = item.bText;
                        select.appendChild(option);
                    });
                }

                $('#NMotivoDaViagem').multiselect('rebuild');
            }
        })
        .catch(error => {
            alert(`Erro. ${error}`);
        });
}

const carregarNPassageiro = () => {
    fetch(`/BasePopulate/ListarNPassageiroJson?GuidId=${encodeURIComponent(_transacaoId)}`, {
        method: 'GET',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        }
    })
        .then(response => response.json())
        .then(responseData => {
            let select = document.getElementById('NPassageiro');
            select.innerHTML = '';
            if (responseData && responseData.ret) {
                const basePopulate = responseData.basePopulate
                let option = document.createElement('option');
                if (basePopulate && basePopulate.length > 0) {
                    basePopulate.forEach(item => {
                        let option = document.createElement('option');
                        option.value = item.bValue;
                        option.textContent = item.bText;
                        select.appendChild(option);
                    });
                }

                $('#NPassageiro').multiselect('rebuild');
            }
        })
        .catch(error => {
            alert(`Erro. ${error}`);
        });
}

const carregarNProduto = () => {
    fetch(`/BasePopulate/ListarNProdutoJson?GuidId=${encodeURIComponent(_transacaoId)}`, {
        method: 'GET',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        }
    })
        .then(response => response.json())
        .then(responseData => {
            let select = document.getElementById('NProduto');
            select.innerHTML = '';
            if (responseData && responseData.ret) {
                const basePopulate = responseData.basePopulate
                let option = document.createElement('option');
                if (basePopulate && basePopulate.length > 0) {
                    basePopulate.forEach(item => {
                        let option = document.createElement('option');
                        option.value = item.bValue;
                        option.textContent = item.bText;
                        select.appendChild(option);
                    });
                }

                $('#NProduto').multiselect('rebuild');
            }
        })
        .catch(error => {
            alert(`Erro. ${error}`);
        });
}

const carregarNDespesa = () => {
    fetch(`/BasePopulate/ListarNDespesaJson?GuidId=${encodeURIComponent(_transacaoId)}`, {
        method: 'GET',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        }
    })
        .then(response => response.json())
        .then(responseData => {
            let select = document.getElementById('NDespesa');
            select.innerHTML = '';
            if (responseData && responseData.ret) {
                const basePopulate = responseData.basePopulate
                let option = document.createElement('option');
                if (basePopulate && basePopulate.length > 0) {
                    basePopulate.forEach(item => {
                        let option = document.createElement('option');
                        option.value = item.bValue;
                        option.textContent = item.bText;
                        select.appendChild(option);
                    });
                }

                $('#NDespesa').multiselect('rebuild');
            }
        })
        .catch(error => {
            alert(`Erro. ${error}`);
        });
}

const carregarNNomeFornecedor = () => {
    fetch(`/BasePopulate/ListarNNomeFornecedorJson?GuidId=${encodeURIComponent(_transacaoId)}`, {
        method: 'GET',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        }
    })
        .then(response => response.json())
        .then(responseData => {
            let select = document.getElementById('NNomeFornecedor');
            select.innerHTML = '';
            if (responseData && responseData.ret) {
                const basePopulate = responseData.basePopulate
                let option = document.createElement('option');
                if (basePopulate && basePopulate.length > 0) {
                    basePopulate.forEach(item => {
                        let option = document.createElement('option');
                        option.value = item.bValue;
                        option.textContent = item.bText;
                        select.appendChild(option);
                    });
                }

                $('#NNomeFornecedor').multiselect('rebuild');
            }
        })
        .catch(error => {
            alert(`Erro. ${error}`);
        });
}

const carregarNLocalizador = () => {
    fetch(`/BasePopulate/ListarNLocalizadorJson?GuidId=${encodeURIComponent(_transacaoId)}`, {
        method: 'GET',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        }
    })
        .then(response => response.json())
        .then(responseData => {
            let select = document.getElementById('NLocalizador');
            select.innerHTML = '';
            if (responseData && responseData.ret) {
                const basePopulate = responseData.basePopulate
                let option = document.createElement('option');
                if (basePopulate && basePopulate.length > 0) {
                    basePopulate.forEach(item => {
                        let option = document.createElement('option');
                        option.value = item.bValue;
                        option.textContent = item.bText;
                        select.appendChild(option);
                    });
                }

                $('#NLocalizador').multiselect('rebuild');
            }
        })
        .catch(error => {
            alert(`Erro. ${error}`);
        });
}

const carregarNBilhete = () => {
    fetch(`/BasePopulate/ListarNBilheteJson?GuidId=${encodeURIComponent(_transacaoId)}`, {
        method: 'GET',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        }
    })
        .then(response => response.json())
        .then(responseData => {
            let select = document.getElementById('NBilhete');
            select.innerHTML = '';
            if (responseData && responseData.ret) {
                const basePopulate = responseData.basePopulate
                let option = document.createElement('option');
                if (basePopulate && basePopulate.length > 0) {
                    basePopulate.forEach(item => {
                        let option = document.createElement('option');
                        option.value = item.bValue;
                        option.textContent = item.bText;
                        select.appendChild(option);
                    });
                }

                $('#NBilhete').multiselect('rebuild');
            }
        })
        .catch(error => {
            alert(`Erro. ${error}`);
        });
}

const carregarNRotaCompleta = () => {
    fetch(`/BasePopulate/ListarNRotaCompletaJson?GuidId=${encodeURIComponent(_transacaoId)}`, {
        method: 'GET',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        }
    })
        .then(response => response.json())
        .then(responseData => {
            let select = document.getElementById('NRotaCompleta');
            select.innerHTML = '';
            if (responseData && responseData.ret) {
                const basePopulate = responseData.basePopulate
                let option = document.createElement('option');
                if (basePopulate && basePopulate.length > 0) {
                    basePopulate.forEach(item => {
                        let option = document.createElement('option');
                        option.value = item.bValue;
                        option.textContent = item.bText;
                        select.appendChild(option);
                    });
                }

                $('#NRotaCompleta').multiselect('rebuild');
            }
        })
        .catch(error => {
            alert(`Erro. ${error}`);
        });
}

const carregarNVeiculo = () => {
    fetch(`/BasePopulate/ListarNVeiculoJson?GuidId=${encodeURIComponent(_transacaoId)}`, {
        method: 'GET',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        }
    })
        .then(response => response.json())
        .then(responseData => {
            let select = document.getElementById('NVeiculo');
            select.innerHTML = '';
            if (responseData && responseData.ret) {
                const basePopulate = responseData.basePopulate
                let option = document.createElement('option');
                if (basePopulate && basePopulate.length > 0) {
                    basePopulate.forEach(item => {
                        let option = document.createElement('option');
                        option.value = item.bValue;
                        option.textContent = item.bText;
                        select.appendChild(option);
                    });
                }

                $('#NVeiculo').multiselect('rebuild');
            }
        })
        .catch(error => {
            alert(`Erro. ${error}`);
        });
}

const carregarNVoucher = () => {
    fetch(`/BasePopulate/ListarNVoucherJson?GuidId=${encodeURIComponent(_transacaoId)}`, {
        method: 'GET',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        }
    })
        .then(response => response.json())
        .then(responseData => {
            let select = document.getElementById('NVoucher');
            select.innerHTML = '';
            if (responseData && responseData.ret) {
                const basePopulate = responseData.basePopulate
                let option = document.createElement('option');
                if (basePopulate && basePopulate.length > 0) {
                    basePopulate.forEach(item => {
                        let option = document.createElement('option');
                        option.value = item.bValue;
                        option.textContent = item.bText;
                        select.appendChild(option);
                    });
                }

                $('#NVoucher').multiselect('rebuild');
            }
        })
        .catch(error => {
            alert(`Erro. ${error}`);
        });
}

const carregarNApartamentos = () => {
    fetch(`/BasePopulate/ListarNApartamentosJson?GuidId=${encodeURIComponent(_transacaoId)}`, {
        method: 'GET',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        }
    })
        .then(response => response.json())
        .then(responseData => {
            let select = document.getElementById('NApartamentos');
            select.innerHTML = '';
            if (responseData && responseData.ret) {
                const basePopulate = responseData.basePopulate
                let option = document.createElement('option');
                if (basePopulate && basePopulate.length > 0) {
                    basePopulate.forEach(item => {
                        let option = document.createElement('option');
                        option.value = item.bValue;
                        option.textContent = item.bText;
                        select.appendChild(option);
                    });
                }

                $('#NApartamentos').multiselect('rebuild');
            }
        })
        .catch(error => {
            alert(`Erro. ${error}`);
        });
}

const carregarNRegime = () => {
    fetch(`/BasePopulate/ListarNRegimeJson?GuidId=${encodeURIComponent(_transacaoId)}`, {
        method: 'GET',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        }
    })
        .then(response => response.json())
        .then(responseData => {
            let select = document.getElementById('NRegime');
            select.innerHTML = '';
            if (responseData && responseData.ret) {
                const basePopulate = responseData.basePopulate
                let option = document.createElement('option');
                if (basePopulate && basePopulate.length > 0) {
                    basePopulate.forEach(item => {
                        let option = document.createElement('option');
                        option.value = item.bValue;
                        option.textContent = item.bText;
                        select.appendChild(option);
                    });
                }

                $('#NRegime').multiselect('rebuild');
            }
        })
        .catch(error => {
            alert(`Erro. ${error}`);
        });
}

const carregarNQtDiarias = () => {
    fetch(`/BasePopulate/ListarNQtDiariasJson?GuidId=${encodeURIComponent(_transacaoId)}`, {
        method: 'GET',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        }
    })
        .then(response => response.json())
        .then(responseData => {
            let select = document.getElementById('NQtDiarias');
            select.innerHTML = '';
            if (responseData && responseData.ret) {
                const basePopulate = responseData.basePopulate
                let option = document.createElement('option');
                if (basePopulate && basePopulate.length > 0) {
                    basePopulate.forEach(item => {
                        let option = document.createElement('option');
                        option.value = item.bValue;
                        option.textContent = item.bText;
                        select.appendChild(option);
                    });
                }

                $('#NQtDiarias').multiselect('rebuild');
            }
        })
        .catch(error => {
            alert(`Erro. ${error}`);
        });
}

const carregarNFaturaNumero = () => {
    fetch(`/BasePopulate/ListarNFaturaNumeroJson?GuidId=${encodeURIComponent(_transacaoId)}`, {
        method: 'GET',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        }
    })
        .then(response => response.json())
        .then(responseData => {
            let select = document.getElementById('NFaturaNumero');
            select.innerHTML = '';
            if (responseData && responseData.ret) {
                const basePopulate = responseData.basePopulate
                let option = document.createElement('option');
                if (basePopulate && basePopulate.length > 0) {
                    basePopulate.forEach(item => {
                        let option = document.createElement('option');
                        option.value = item.bValue;
                        option.textContent = item.bText;
                        select.appendChild(option);
                    });
                }

                $('#NFaturaNumero').multiselect('rebuild');
            }
        })
        .catch(error => {
            alert(`Erro. ${error}`);
        });
}

const carregarNNumeroCartao = () => {
    fetch(`/BasePopulate/ListarNNumeroCartaoJson?GuidId=${encodeURIComponent(_transacaoId)}`, {
        method: 'GET',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        }
    })
        .then(response => response.json())
        .then(responseData => {
            let select = document.getElementById('NNumeroCartao');
            select.innerHTML = '';
            if (responseData && responseData.ret) {
                const basePopulate = responseData.basePopulate
                let option = document.createElement('option');
                if (basePopulate && basePopulate.length > 0) {
                    basePopulate.forEach(item => {
                        let option = document.createElement('option');
                        option.value = item.bValue;
                        option.textContent = item.bText;
                        select.appendChild(option);
                    });
                }

                $('#NNumeroCartao').multiselect('rebuild');
            }
        })
        .catch(error => {
            alert(`Erro. ${error}`);
        });
}

const carregarPopulate = () => {
    carregarNSolicitante();
    carregarNAutorizacaoCartao();
    carregarNReserva();
    carregarNAprovador();
    carregarNMotivoDaViagem();
    carregarNPassageiro();
    carregarNProduto();
    carregarNDespesa();
    carregarNNomeFornecedor();
    carregarNLocalizador();
    carregarNBilhete();
    carregarNRotaCompleta();
    carregarNVeiculo();
    carregarNVoucher();
    carregarNApartamentos();
    carregarNRegime();
    carregarNQtDiarias();
    carregarNFaturaNumero();
    carregarNNumeroCartao();
}

let chartBarVertical = null;
let chartPizzaInstance = null;

const ctxBarVertical = document.getElementById('chartBarVertical');
const ctxPizza = document.getElementById('chartPizza').getContext('2d');

const FiltrarGraficoDinamico = (event) => {

    event.preventDefault();

    let _NSolicitante = $('#NSolicitante').val();
    let _NAutorizacaoCartao = $('#NAutorizacaoCartao').val();
    let _NNReserva = $('#NReserva').val();
    let _NAprovador = $('#NAprovador').val();
    let _NMotivoDaViagem = $('#NMotivoDaViagem').val();
    let _NPassageiro = $('#NPassageiro').val();
    let _NProduto = $('#NProduto').val();
    let _NDespesa = $('#NDespesa').val();
    let _NNomeFornecedor = $('#NNomeFornecedor').val();
    let _NLocalizador = $('#NLocalizador').val();
    let _NBilhete = $('#NBilhete').val();
    let _NRotaCompleta = $('#NRotaCompleta').val();
    let _NVeiculo = $('#NVeiculo').val();
    let _NVoucher = $('#NVoucher').val();
    let _NApartamentos = $('#NApartamentos').val();
    let _NRegime = $('#NRegime').val();
    let _NQtDiarias = $('#NQtDiarias').val();
    let _NFaturaNumero = $('#NFaturaNumero').val();
    let _NNumeroCartao = $('#NNumeroCartao').val();

    let dados = {
        GuidId: _transacaoId,
        NSolicitante: _NSolicitante,
        NAutorizacaoCartao: _NAutorizacaoCartao,
        NReserva: _NNReserva,
        NAprovador: _NAprovador,
        NMotivoDaViagem: _NMotivoDaViagem,
        NPassageiro: _NPassageiro,
        NProduto: _NProduto,
        NDespesa: _NDespesa,
        NNomeFornecedor: _NNomeFornecedor,
        NLocalizador: _NLocalizador,
        NBilhete: _NBilhete,
        NRotaCompleta: _NRotaCompleta,
        NVeiculo: _NVeiculo,
        NVoucher: _NVoucher,
        NApartamentos: _NApartamentos,
        NRegime: _NRegime,
        NQtDiarias: _NQtDiarias, //_NQtDiarias ? parseInt(_NQtDiarias) : null,
        NFaturaNumero: _NFaturaNumero,
        NNumeroCartao: _NNumeroCartao
    };

    fetch('/Transacao/ListarGraficoDinamicoJson', {
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
                const transacao = responseData.transacaoDados;
                if (transacao && transacao.length > 0) {
                    showChartBarVertical(transacao);
                    showChartPie(transacao);
                }
                else {
                    if (chartBarVertical) {
                        chartBarVertical.destroy();
                    }
                    if (chartPizzaInstance) {
                        chartPizzaInstance.destroy();
                    }
                    alert("Nenhum registro encontrado.");
                }
            }
            else {
                alert(`Erro response: ${responseData.msg}`);
            }
        })
        .catch(error => {
            alert(`Erro ${error}`);
        })
}

const showChartBarVertical = (transacaoDados) => {
    // Destroi gráfico anterior, se existir
    if (chartBarVertical) {
        chartBarVertical.destroy();
    }
    chartBarVertical = new Chart(ctxBarVertical, {
        type: 'bar',
        data: {
            labels: transacaoDados.map(item => item.cCusto), 
            datasets: [{
                label: 'Centro de custo',
                data: transacaoDados.map(item => item.totalCliente), 
                backgroundColor: 'rgba(75, 192, 192, 0.2)'
            }]
        },
        options: {
            animation: {
                duration: 5000,        
                easing: 'easeOutQuart' 
            },
            scales: {
                y: {
                    beginAtZero: true
                }
            }
        }
    });
}

const showChartPie = (transacaoDados) => {
    if (chartPizzaInstance) {
        chartPizzaInstance.destroy();
    }
    const cores = transacaoDados.map(item => `rgba(${parseInt(item.rgba.r)},${item.rgba.g},${item.rgba.b},0.6)`);
    chartPizzaInstance = new Chart(ctxPizza, {
        type: 'pie',
        data: {
            labels: transacaoDados.map(item => item.cCusto),
            datasets: [{
                label: 'Vendas',
                data: transacaoDados.map(item => item.totalCliente),
                backgroundColor: cores,
                borderWidth: 1
            }]
        },
        options: {
            animation: {
                duration: 5000, 
                easing: 'easeOutBounce' 
            }
        }
    });
}

//document.addEventListener('DOMContentLoaded', carregarPopulate);

document.addEventListener('DOMContentLoaded', function () {
    $('.fcouto1331').multiselect({
        nonSelectedText: 'Selecione.',
        buttonWidth: '100%',
        maxHeight: 200,
        includeSelectAllOption: true,
        selectAllText: 'Todos',
        allSelectedText: 'Todos selecionados',
        nonSelectedText: 'Nenhum selecionado',
        widthSynchronizationMode: 'always',
    });

    carregarPopulate();
});
