window.onload = () => {

  main();
};

function get(url) {
  let request = new XMLHttpRequest();
  request.open("GET", url, false);
  request.send();
  return request.responseText;
}

function main() {
  const card = document.getElementById("row");

  data = get("http://localhost:3001/perfume");
  telefones = JSON.parse(data);
  console.log(telefones);
  card.innerHTML = "";

  telefones.forEach((element) => {
    let modelo = element.modelo;
    let preco = element.preco;
    let img = element.img;
    let link = element.link;
    let desc = element.desc;

    var f = preco.toLocaleString('pt-br',{style: 'currency', currency: 'BRL'});
    container = `

    <div class="cardI green" id="card">
        <img class="image" src="${img}" alt="money" />
        <h2>${modelo}</h2>
        <p>${f}</p>
        <a class="loja" href="${link}"> Acesso a loja </a>

    </div>

    `;
    card.innerHTML += container;
  });
}
