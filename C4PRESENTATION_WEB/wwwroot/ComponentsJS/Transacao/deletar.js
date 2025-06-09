const deletar = (GuidId) => {
    if (window.confirm('Deseja realmente prosseguir?')) {
        fetch(`/Transacao/DeletarJson?GuidId=${encodeURIComponent(GuidId)}`, {
            method: 'DELETE',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            }
        })
            .then(response => response.json())
            .then(responseData => {
                if (responseData && responseData.ret) {
                    alert(responseData.msg);
                    carregarTransacao();
                }
                else {
                    alert(responseData.msg)
                }
            })
            .catch(error => {
                alert(error);
            });
    }
}