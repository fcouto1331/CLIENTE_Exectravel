const carregarGrafico = () => {
    fetch(`/Transacao/ListarGraficoJson?GuidId=${encodeURIComponent(_transacaoId)}`, {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json'
        }
    })
        .then(response => response.json())
        .then(responseData => {
            let registros = document.getElementById('registrosGrafico');
            registros.innerHTML = '';
            if (responseData && responseData.ret) {
                const transacao = responseData.transacaoDados;
                if (transacao && transacao.length > 0) {
                    let tabela = '';
                    tabela += `<table class="table table-bordered"><caption>Total: ${transacao.length}</caption>`;
                    tabela += `<thead class="bg-light text-dark">
                        <tr>
                            <th style="width:80%">CCusto</th>
                            <th style="width:20%">TotalCliente</th>
                        </tr>
                    </thead><tbody>`;

                    let soma = 0;

                    transacao.forEach(item => {
                        tabela += `<tr>
                            <td>${item.cCusto}</td>
                            <td>${formatarDecimalBR(item.totalCliente)}</td>
                        </tr>`;

                        soma += item.totalCliente
                    });

                    tabela += `<tr><td></td><td>Total: ${formatarDecimalBR(soma)}</td></tr>`

                    tabela += '</tbody></table>';
                    registros.innerHTML = tabela;

                    showChartBarVertical(transacao);
                    showChartPie(transacao);

                } else {
                    registros.innerHTML = '<div>Nenhum encontrado.</div>';
                }
            } else {
                registros.innerHTML = `<div class="text-danger">${responseData.output?.msg ?? 'Erro.'}</div>`;
            }
        })
        .catch(error => {
            alert(`${error}`)
        });
}

const showChartBarVertical = (transacaoDados) => {
    const ctx = document.getElementById('chartBarVertical');
    new Chart(ctx, {
        type: 'bar',
        data: {
            labels: transacaoDados.map(item => item.cCusto), //['Janeiro', 'Fevereiro', 'Março', 'Abril', 'Maio', 'Julho', 'Julho', 'Agosto', 'Setembro', 'Outubro', 'Novembro', 'Dezembro'],
            datasets: [{
                label: 'Centro de custo',
                data: transacaoDados.map(item => item.totalCliente), //[12, 19, 3, 5, 19, 25, 89, 92, 5, 1, 52],
                backgroundColor: 'rgba(75, 192, 192, 0.2)'
            }]
        },
        options: {
            animation: {
                duration: 20000,        // animation duration in milliseconds
                easing: 'easeOutQuart' // easing function for smooth effect
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
    const ctxPizza = document.getElementById('chartPie').getContext('2d');
    const cores = transacaoDados.map(item => `rgba(${parseInt(item.rgba.r)},${item.rgba.g},${item.rgba.b},0.6)`);
    new Chart(ctxPizza, {
        type: 'pie',
        data: {
            labels: transacaoDados.map(item => item.cCusto),
            datasets: [{
                label: 'Vendas',
                data: transacaoDados.map(item => item.totalCliente),
                //backgroundColor: [
                //    'rgba(100, 100, 100, 0.6)',
                //    'rgba(54, 162, 235, 0.6)',
                //    'rgba(255, 206, 86, 0.6)',
                //    'rgba(75, 192, 192, 0.6)',
                //    'rgba(153, 102, 255, 0.6)',
                //    'rgba(255, 159, 64, 0.6)',
                //    'rgba(199, 199, 199, 0.6)',
                //    'rgba(83, 102, 255, 0.6)',
                //    'rgba(100, 255, 218, 0.6)',
                //    'rgba(255, 99, 255, 0.6)',
                //    'rgba(0, 200, 83, 0.6)',
                //    'rgba(0, 150, 136, 0.6)'
                //],
                backgroundColor: cores,
                borderWidth: 1
            }]
        },
        options: {
            animation: {
                duration: 10000, // animation duration in ms (default is 1000)
                easing: 'easeOutBounce' // easing effect for animation
            }
        }
    });
}

document.addEventListener('DOMContentLoaded', carregarGrafico);


/*

@*GRAFICO*@
@* <script src="https://cdn.jsdelivr.net/npm/chart.js"></script> *@
@*<script src="~/js/chartjs-v4-4-9.js"></script>
<canvas id="myChart"></canvas>
<script>
    const ctx = document.getElementById('myChart');
    new Chart(ctx, {
      type: 'bar',
      data: {
        labels: ['Janeiro', 'Fevereiro', 'Março', 'Abril', 'Maio', 'Julho', 'Julho', 'Agosto', 'Setembro', 'Outubro', 'Novembro', 'Dezembro'],
        datasets: [{
          label: 'Vendas',
          data: [12, 19, 3, 5, 19, 25, 89, 92, 5, 1, 52],
          backgroundColor: 'rgba(75, 192, 192, 0.2)'
        }]
      }
    });
</script>

<div style="width: 50% !important;">
    <canvas id="chartPizza"></canvas>
</div>
<script>
    const ctxPizza = document.getElementById('chartPizza').getContext('2d');

    new Chart(ctxPizza, {
      type: 'pie',
      data: {
        labels: ['Janeiro', 'Fevereiro', 'Março', 'Abril', 'Maio', 'Junho', 'Julho', 'Agosto', 'Setembro', 'Outubro', 'Novembro', 'Dezembro'],
        datasets: [{
          label: 'Vendas',
          data: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12],
          backgroundColor: [
            'rgba(100, 100, 100, 0.6)',
            'rgba(54, 162, 235, 0.6)',
            'rgba(255, 206, 86, 0.6)',
            'rgba(75, 192, 192, 0.6)',
            'rgba(153, 102, 255, 0.6)',
            'rgba(255, 159, 64, 0.6)',
            'rgba(199, 199, 199, 0.6)',
            'rgba(83, 102, 255, 0.6)',
            'rgba(100, 255, 218, 0.6)',
            'rgba(255, 99, 255, 0.6)',
            'rgba(0, 200, 83, 0.6)',
            'rgba(0, 150, 136, 0.6)'
          ],
          borderWidth: 1
        }]
      }
    });
</script>

<canvas id="charBarHorizontal"></canvas>
<script>
    const ctxBarHorizontal = document.getElementById('charBarHorizontal');

    new Chart(ctxBarHorizontal, {
      type: 'bar',
      data: {
        labels: ['Janeiro', 'Fevereiro', 'Março', 'Abril', 'Maio', 'Junho', 'Julho', 'Agosto', 'Setembro', 'Outubro', 'Novembro', 'Dezembro'],
        datasets: [{
          label: 'Vendas',
          data: [12, 19, 3, 5, 19, 25, 89, 92, 5, 1, 52, 38],
          backgroundColor: 'rgba(75, 192, 192, 0.2)',
          borderColor: 'rgba(75, 192, 192, 1)',
          borderWidth: 1
        }]
      },
      options: {
        indexAxis: 'y', // transforma em gráfico de barras horizontal
        scales: {
          x: {
            beginAtZero: true
          }
        }
      }
    });
</script>*@

*/