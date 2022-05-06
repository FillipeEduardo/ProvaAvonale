<h1 align="center">Prova Avonale - Fillipe Eduardo Oliveira dos Santos</h1>

##  About this project

[![Codacy Badge](https://api.codacy.com/project/badge/Grade/70e91d6504ee47dfad044b3576868056)](https://app.codacy.com/gh/lipaoos/ProvaAvonale?utm_source=github.com&utm_medium=referral&utm_content=lipaoos/ProvaAvonale&utm_campaign=Badge_Grade_Settings)

A prova foi feita 100%, com as validações necessarias, e com todos os retornos possiveis para cada API.

Questão 1: Foi criado a classe ProdutosModel para instanciação do produto a ser inserido no estoque, atraves de injeção de dependencia com o banco de dados SQLite. Metodo post funcionando corretamente com as suas validações e seus retornos possiveis.

Questão 2: Método get retornando uma lista com todos os produtos salvos no banco de dados SQLite.

QUestão 3: Metodo get retornando um json com um produto(objeto) atraves do Id inserido na rota.

Questão 4: A API ComprasController chama a API PagamentoController, caso a api de pagamento retorne o estado APROVADO, é feito uma verificação se possui a quantidade requerida no estoque cadastrado no banco de dados e o produto é consumido do estoque.

Questão 5: Remove um produto do estoque atraves do metodo Delete da API ProdutosController

Questão 6: Foi criado a classe PagamentoModel para envio das informações do metodo post da API PagamentoController. Foi criado a interface IPagamentoRepository para injeção de dependencia do refit e consumir o gateway de pagamento externo em mock. Porem esse gateway está offline. Porem é possivel verificar a utilização correta da biblioteca refit, com a criação da interface, struct result e classe criada
Gateway informado no link do exercicio: (http://sv-dev-01.pareazul.com.br:8080/api/gateways/compras)

### Technologies
<p display="inline-block">
  <img width="48" src="https://www.freeiconspng.com/uploads/c-logo-icon-18.png" alt="csharp-logo"/>
</p>
                                                                                                  
### Development Tools

<p display="inline-block">
  <img width="48" src="https://static.wikia.nocookie.net/logopedia/images/e/ec/Microsoft_Visual_Studio_2022.svg" alt="vs-logo"/>
  <img width="48" src="https://upload.wikimedia.org/wikipedia/commons/thumb/9/9a/Visual_Studio_Code_1.35_icon.svg/2048px-Visual_Studio_Code_1.35_icon.svg.png" alt="vscode-logo"/>
</p>

## Running
dotnet run