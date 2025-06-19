$(document).ready(function () {

    //$('#meuSelect').multiselect(); // Quando o select for estático

    $('.fcouto1331').multiselect({ // Bootstrap Multiselect Config
        nonSelectedText: 'Selecione.',
        buttonWidth: '100%', // largura do botão
        maxHeight: 200, // altura máxima da lista dropdown
        includeSelectAllOption: true,
        selectAllText: 'Todos', // Check All
        allSelectedText: 'Todos selecionados', // All Selected
        nonSelectedText: 'Nenhum selecionado', // None selected
        widthSynchronizationMode: 'always', // Limita o text a box
    });

    carregarPopulate();
    
});

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

const FiltrarGraficoDinamico = (event) => {

    event.preventDefault();

    let _NSolicitante = $('#NSolicitante').val()

    console.log(`_NSolicitante: ${_NSolicitante}`);

}

//document.addEventListener('DOMContentLoaded', carregarPopulate);